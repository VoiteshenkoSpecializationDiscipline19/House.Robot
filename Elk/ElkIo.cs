using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using Microsoft.Ccr.Adapters.IO;
using Microsoft.Ccr.Core;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.ServiceModel.Dssp;
using System.IO;
using System.Diagnostics;

namespace Robotics.Elk
{
    /// <summary>
    /// ElkIOPort is an internal port for queueing the raw data strings from the Elk panel
    /// for processing.
    /// </summary>
    internal class ElkIOPort : DsspResponsePort<string> { }

    public partial class ElkService : DsspServiceBase
    {
        private TcpClient tcpClient;
        private NetworkStream networkStream;


        /// <summary>
        /// Connect to the Elk M1G panel.
        /// </summary>
        private void Connect()
        {
            LogInfo("Connect to Elk");
            if (tcpClient != null)
                tcpClient.Close();

            tcpClient = new TcpClient();

            tcpClient.ReceiveTimeout = 1000; //TODO: Do I need this?
            tcpClient.Connect(_state.HostName, _state.Port);
            networkStream = tcpClient.GetStream();
            LogInfo(string.Format("Read Timeout = {0}", networkStream.ReadTimeout));
        }

        /// <summary>
        /// ElkReader opens a socket connection to the hardware panel. It then
        /// enters a loop that
        /// </summary>
        /// <returns></returns>
        public IEnumerator<ITask> ElkReader()
        {
            Connect();

            SpawnIterator(GetInitialState);

            Exception ex = null;
            var buffer = new byte[256];
            int bytesRead = -1;
            do
            {
                var resultPort = StreamAdapter.Read(networkStream, buffer, 0, buffer.Length);
                yield return resultPort.Choice();

                ex = resultPort;
                if (ex != null)
                {
                    LogError(ex);

                    //TODO: Retry connecting to the Elk on an exception. Keep trying forever :)
                    while (!tcpClient.Connected)
                    {
                        LogInfo("Retry loop");
                        try
                        {
                            Connect();
                        }
                        catch (Exception)
                        {
                        }
                        if (!tcpClient.Connected)
                            yield return Timeout(1000);
                    }
                    continue;
                }

                bytesRead = resultPort;
                if (bytesRead != 0)
                    _ioPort.Post(Encoding.ASCII.GetString(buffer, 0, bytesRead));

            } while (bytesRead != 0);
            yield return Timeout(1000);
            LogInfo("Exit Elk read loop");
        }

        public IEnumerator<ITask> GetInitialState()
        {
            yield return Timeout(ElkConstants.LONG_COMM_DELAY); // Wait long enough for the IO iterator to start reading.
            // Send a request to the Elk panel get a report of the entire zone status.

            ElkRequest.SendElkMessage(networkStream, ElkRequest.ZoneStatus);
            yield return Timeout(ElkConstants.SHORT_COMM_DELAY);

            ElkRequest.SendElkMessage(networkStream, ElkRequest.OutputStatus);
            yield return Timeout(ElkConstants.SHORT_COMM_DELAY);

            for (int i = 0; i < ElkConstants.MAX_ZONES; i++)
            {
                ElkRequest.SendElkMessage(networkStream, string.Format(ElkRequest.TextDescription, (byte)TextType.ZoneName, i + 1));
                yield return Timeout(ElkConstants.SHORT_COMM_DELAY); // Pause so that we don't flood the hardware.
            }

            yield break;
        }


        #region Raw Elk data parsers

        /// <summary>
        /// An exclusive receiver that is combined with the main interleave. This receiver
        /// will parse the raw data from the security panel, update state, and send event notifications.
        /// 
        /// Note that each of the helper functions that parse the data are free to update state since they are called
        /// from an exclusive receiver.
        /// </summary>
        /// <param name="data">Raw data string from the Elk M1G</param>
        private void ElkDataHandler(string data)
        {
            string messageType = data.Substring(2, 2);

            switch (messageType)
            {
                case "ZC": // Zone status change
                    ProcessZoneChange(data);
                    break;

                case "ZS": // Zone status report
                    ProcessZoneStatusReport(data);
                    break;

                case "CC": // Output status change
                    ProcessOutputChange(data);
                    break;

                case "CS": // Output status report.
                    ProcessOutputStatusChangeReport(data);
                    break;

                case "TC": // Task activated
                    ProcessTaskChange(data);
                    break;

                case "SD":
                    ProcessStringName(data);
                    break;

                case "LD":
                    LogInfo("Log => " + data);
                    break;
            }

        }

        private void ProcessZoneChange(string buffer)
        {
            var id = byte.Parse(buffer.Substring(4, 3));
            var state = (ZoneState)byte.Parse(buffer.Substring(7, 1), NumberStyles.HexNumber);
            var message = new ZoneChanged(id, state);

            _mainPort.Post(message);
        }

        private void ProcessZoneStatusReport(string buffer)
        {
            var message = new ReplaceZones();
            message.Body.Zones = new Zone[ElkConstants.MAX_ZONES];
            for (byte i = 0; i < ElkConstants.MAX_ZONES; i++)
                message.Body.Zones[i] = new Zone
                {
                    Id = (byte)(i + 1),
                    State = (ZoneState)(buffer[i + 4] & 0x0f),
                    Timestamp = DateTime.Now                    
                };

            _mainPort.Post(message);
        }

        private void ProcessOutputChange(string buffer)
        {
            var id = byte.Parse(buffer.Substring(4, 3));
            var state = (OutputState)(buffer[7] & 0x0f);
            var message = new OutputChanged(id, state);

            _mainPort.Post(message);
        }

        private void ProcessOutputStatusChangeReport(string buffer)
        {
            var message = new ReplaceOutputs();
            message.Body.Outputs = new Output[ElkConstants.MAX_OUTPUTS];
            for (int i = 0; i < ElkConstants.MAX_OUTPUTS; i++)
                message.Body.Outputs[i] =  new Output
                    {
                        Id = (byte)(i + 1),
                        State = (OutputState)(buffer[i + 4] & 0x0f), // Off is 0x30. On is 0x31.
                        Timestamp = DateTime.Now
                    };

            _mainPort.Post(message);
        }

        private void ProcessTaskChange(string buffer)
        {
            byte taskId = byte.Parse(buffer.Substring(4, 3));
            var message = new UpdateTask(taskId);
            SendNotification(_submgrPort, message); //TODO: Follow the update pattern? Add LastTaskUpdate to state?
        }

        private void ProcessStringName(string data)
        {
            TextType t = (TextType)int.Parse(data.Substring(4, 2));
            if (t != TextType.ZoneName) return;

            byte id = byte.Parse(data.Substring(6, 3));
            if (id == 0) return;

            var nameChars = data.ToCharArray(9, 16);    // According to the documentation, the high bit will be set for "show on keypad" text.            
            nameChars[0] &= (char)0x7fff;               // So we'll mask out the high bit just in case.
            var name = new string(nameChars);

            _state.Zones[id - 1].Name = name;

            //TODO: Add this if needed. Maybe remove the UpdateStringNames class
            //var message = new UpdateName
            //{
            //    Body = new StringName { TextType = t, Id = id, Name = name }
            //};

            //SendNotification(_submgrPort, message);
        }
    }

        #endregion

    #region ELK data formatting utilities
    /// <summary>
    /// An extension class that is used to compute checksums
    /// of data sent to the Elk security panel.
    /// </summary>
    public static class Checksum
    {
        /// <summary>
        /// Conputes a checksum for an ASCII string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte ComputeASCIIChecksum(this string s)
        {
            return ComputeASCIIChecksum(Encoding.ASCII.GetBytes(s));
        }

        /// <summary>
        /// Computes a checksum for a substring of an ASCII string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte ComputeASCIIChecksum(this string s, int startIndex, int length)
        {
            return ComputeASCIIChecksum(Encoding.ASCII.GetBytes(s.Substring(startIndex, length)));
        }


        /// <summary>
        /// Computes a checksum for ASCII characters in a byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte ComputeASCIIChecksum(this byte[] buffer)
        {
            return ComputeASCIIChecksum(buffer, 0, buffer.Length);
        }


        /// <summary>
        /// Computes a checksum for a subset of bytes in an array.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte ComputeASCIIChecksum(this byte[] buffer, int startIndex, int length)
        {
            byte sum = 0;

            for (int i = startIndex; i < startIndex + length; i++)
                sum += buffer[i];

            sum ^= 0xff;
            sum++;

            return sum;
        }
    }


    /// <summary>
    /// Format strings for request messages that are
    /// sent to the Elk security panel.
    /// </summary>
    internal static class ElkRequest
    {
        public static readonly string ZoneStatus = "06zs00";
        public static readonly string OutputStatus = "06cs00";
        public static readonly string OutputOn = "0Ecn{0:d3}{1:d5}00";
        public static readonly string OutputOff = "09cf{0:d3}00";
        public static readonly string ToggleOutput = "09ct{0:d3}00";
        public static readonly string ActivateTask = "09tn{0:d3}00";
        public static readonly string TextDescription = "0Bsd{0:d2}{1:d3}00";

        public static void SendElkMessage(Stream stream, string message)
        {
            message += message.ComputeASCIIChecksum().ToString("X") + "\n";

            var buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
        }

    }

    internal enum ElkTextType
    {
        ZoneName,
        AreaName,
        UserName,
        KeypadName,
        OutputName,
        TaskName,
        TelephoneName,
        LightName,
        AlarmDurationName,
        CustomSettings,
        CountersNames,
        ThermostatNames,
        FunctionKey1Name,
        FunctionKey2Name,
        FunctionKey3Name,
        FunctionKey4Name,
        FunctionKey5Name,
        FunctionKey6Name,
        AudioZoneName,
        AudioSourceName
    }
    #endregion
}