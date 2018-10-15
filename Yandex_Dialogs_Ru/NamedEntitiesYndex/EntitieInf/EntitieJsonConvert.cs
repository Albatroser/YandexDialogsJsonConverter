using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf
{

    class EntitieJsonConvert : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IEntitie));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["type"].Value<string>() == "YANDEX.GEO")
                return jo.ToObject<GEO>(serializer);

            if (jo["type"].Value<string>() == "YANDEX.NUMBER")
                return jo.ToObject<NUMBER>(serializer);

            if (jo["type"].Value<string>() == "YANDEX.FIO")
                return jo.ToObject<FIO>(serializer);

            if (jo["type"].Value<string>() == "YANDEX.DATETIME")
                return jo.ToObject<DATETIME>(serializer);


            return null;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

}
