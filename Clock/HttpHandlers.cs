using System;
using System.Collections.Generic;
using System.ComponentModel;
using DateTimeExtensions;
using Microsoft.Ccr.Core;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.ServiceModel.Dssp;
using Microsoft.Dss.ServiceModel.DsspServiceBase;
using Microsoft.Dss.Services.SubscriptionManager;
using W3C.Soap;
using Microsoft.Dss.Core.DsspHttp;
using Microsoft.Dss.Core.DsspHttpUtilities;
using Microsoft.Dss.Services.DefaultTarget;
using System.Diagnostics;
using System.Net;


namespace Robotics.Clock
{
    public partial class ClockService : DsspServiceBase
    {
        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> HttpPostHandler(HttpPost httpPost)
        {
            var processedFormData = httpPost.GetHeader<HttpPostRequestData>();
            if (processedFormData != null)
            {
                Update upd = processedFormData.TranslatedOperation as Update;
                Debug.Print("upd {0}", upd.ToString());
            }

            Debug.Print("Done");
            yield break;
        }

        [ServiceHandler(ServiceHandlerBehavior.Concurrent)]
        public IEnumerator<ITask> HttpQueryHandler(HttpQuery httpQuery)
        {
            var processedFormData = httpQuery.GetHeader<HttpPostRequestData>();
            if (processedFormData == null)
            {
                //TODO: post back an error.
                yield break;
            }

            Debug.Print(processedFormData.TranslatedOperation.GetType().Name);
                //QueryLongitude query = processedFormData.TranslatedOperation as QueryLongitude;
                //_mainPort.Post(query);
                //yield return query.ResponsePort.Choice(
                //    response => httpQuery.ResponsePort.Post(new HttpResponseType(HttpStatusCode.OK, response)),
                //    fault => httpQuery.ResponsePort.Post(fault)
                //        //httpQuery.ResponsePort.Post(new HttpResponseType(HttpStatusCode.BadRequest, fault))
                //    );

            yield break;
        }

    }
}