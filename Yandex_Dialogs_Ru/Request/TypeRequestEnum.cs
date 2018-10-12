using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Request
{
    
    /// <summary>
    /// Тип ввода
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeRequestEnum : byte
    {
        /// <summary>
        /// голосовой ввод
        /// </summary>
        SimpleUtterance,
        /// <summary>
        /// нажатие кнопки
        /// </summary>
        ButtonPressed
    }
}
