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
        /// Преоброзовать json запросе в RequestObject 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Request.Request GetRequest(string value)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Request.Request>(value,
               new JsonSerializerSettings() { Converters = { new NamedEntitiesYndex.EntitieInf.EntitieJsonConvert() } });
        }

        /// <summary>
        /// Преоброзовать ответа ResponseObject в json
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string SetResponse(Response.ResponseObject value)
        {
            return Infrastructure.JsonConvert
                .SerializeJSon<YandexDialogsJsonConverter.Response.ResponseObject>(value);
        }
    }
}

