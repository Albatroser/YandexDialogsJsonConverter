using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.ImageCard.CardBase
{
    /// <summary>
    /// Тип карточки. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeCardEnum : byte
    {
        /// <summary>
        /// одно изображение
        /// </summary>
        BigImage,
        /// <summary>
        /// галерея изображений (от 1 до 5)
        /// </summary>
        ItemsList
    }
}