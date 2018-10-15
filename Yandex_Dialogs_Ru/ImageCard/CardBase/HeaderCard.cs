using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.ImageCard.CardBase
{
    [DataContract]
    public struct HeaderCard
    {
        string text;
        /// <summary>
        /// Заголовок галереи изображений.
        /// </summary>
        /// <param name="TextSet">Текст заголовка, обязателен, если передается свойство header.Максимум 64 символа.</param>
        public HeaderCard(string TextSet) { text = TextSet; }

        /// <summary>
        /// Текст заголовка, обязателен, если передается свойство header.Максимум 64 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "text")]
        [JsonProperty(Order = 0)]
        public string Text { get { return text; } }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (HeaderCard)obj;
                return
                    this.Text == that.Text;
            }

            return false;
        }
    }
}
