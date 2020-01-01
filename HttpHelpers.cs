using System;
using System.Collections.Specialized;
using Microsoft.Ccr.Core;


//TODO: Make this DsspResponsePort<byte>
//TODO: Move to assembly with other HTTP stuff. REST functions, etc.


public class ByteResult : PortSet<byte, Exception> { };

public static class HttpHelperExtensions
{
    /// <summary>
    /// Looks up 'name' in the specified collection.
    /// Posts an exception to the result port if name is not found.
    /// Posts an exception to the result port if the found value cannot be converted to a byte.
    /// Otherwise, posts the converted byte value.
    /// </summary>
    /// <param name="nvc"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static ByteResult GetByte(this NameValueCollection nvc, string name)
    {
        var port = new ByteResult();

        if (string.IsNullOrEmpty(name)) //TODO: .NET 4 use IsNullOrWhitespace
        {
            port.Post(new ArgumentNullException(name));
            return port;
        }

        try
        {
            var val = nvc[name];
            byte num = byte.Parse(val);
            port.Post(num);
        }
        catch (Exception ex)
        {
            port.Post(ex);
            return port;
        }

        return port;
    }

    /// <summary>
    /// Looks up 'name' in the specified collection.
    /// Posts defaultValue to the result port if name is not found.
    /// Posts an exception if the value is found, but cannot be converted to a byte.
    /// Otherwise, posts the converted byte value.
    /// </summary>
    /// <param name="nvc"></param>
    /// <param name="name"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public static ByteResult GetByte(this NameValueCollection nvc, string name, byte defaultValue)
    {
        var port = new ByteResult();

        if (string.IsNullOrEmpty(name))
        {
            port.Post(defaultValue);
            return port;
        }

        try
        {
            var val = nvc[name];
            byte num;
            if (!byte.TryParse(val, out num))
                num = defaultValue;
            port.Post(num);
        }
        catch (Exception ex)
        {
            port.Post(ex);
            return port;
        }

        return port;
    }
}
