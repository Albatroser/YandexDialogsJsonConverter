using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter
{
    public class Api
    {
        /// <summary>
        /// Преобразовать json запросе в RequestObject 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Request.Request GetRequest(string value)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Request.Request>(value,
               new JsonSerializerSettings() { Converters = { new Request.NamedEntitiesYndex.EntitieInf.EntitieJsonConvert() } });
        }

        /// <summary>
        /// Преобразовать ответа ResponseObject в json
        /// </summary>
        /// <param name="value">Объект ответа, который необходимо конвертировать в json</param>
        /// <returns></returns>
        public string SetResponse(Response.Response value)
        {
            return Infrastructure.JsonConvert.SerializeJSon<YandexDialogsJsonConverter.Response.Response>(value);
        }

        /// <summary>
        /// Проверить ResponseObject на соответствие требованиям яндекс.диалог и если соответствует, то преобразовать ответа в json
        /// </summary>
        /// <param name="value">Объект ответа, который необходимо конвертировать в json</param>
        /// <param name="Errors">Список обнаруженных ошибок</param>
        /// <returns></returns>
        public string SetResponseCheck(Response.Response value, out Response.Сheck.Error[] Errors)
        {
            Response.Сheck.Response response = new Response.Сheck.Response(value);
            Errors = response.QueueError.ToArray();

            if (!response.Check)
            {
                string text = Infrastructure.JsonConvert.SerializeJSon<YandexDialogsJsonConverter.Response.Response>(value);
                return text;
            }

            return null;
        }
    }
}

