using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    /// <summary>
    /// Проверка ResponseObject на соответствие требованиям яндекс.диалоги
    /// </summary>
    public class Response : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.Response responseObject;

        public Response(YandexDialogsJsonConverter.Response.Response responseObjectSet)
        {
            responseObject = responseObjectSet;
            VersionCheck();

            Session session = new Session(responseObject.Session);
            AddQueueError(session);

            Сheck.ResponseObject response = new Сheck.ResponseObject(responseObject.ResponseObject);
            AddQueueError(response);
        }

        protected void VersionCheck()
        {
            if (responseObject.Version != "1.0")
            {
                ErrorSet(
                  "YandexDialogsJsonConverter.Response.ResponseObject.Version",
                  "Version должна быть равной 1.0: фактическое значение - " + responseObject.Version);
            }
        }
    }
}
