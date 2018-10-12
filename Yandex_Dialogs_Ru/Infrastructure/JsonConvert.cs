using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Infrastructure
{
    class JsonConvert 
    {
        /// <summary>
        /// Заполнение выходной строки JSon по параметрам
        /// </summary>
        /// <typeparam name="T">Тип сущности  в которой необходимо преобразовать парметры в JSon</typeparam>
        /// <param name="t">сущность в которой необходимо преобразовать парметры в JSon</param>
        /// <returns></returns>
        public static string SerializeJSon<T>(T t) { return Newtonsoft.Json.JsonConvert.SerializeObject(t); }
    }

}
