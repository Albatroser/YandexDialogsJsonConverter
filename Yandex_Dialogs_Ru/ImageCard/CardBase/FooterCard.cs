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
    public struct FooterCard 
    {
        /// <summary>
        /// Текст заголовка, обязателен, если передается свойство header.Максимум 64 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "text")]
        [JsonProperty(Order = 0)]
        public string Text { get; set; }


        /// <summary>
        /// Дополнительная кнопка для галереи изображений.
        /// <para> Игнорируется для карточки типа ItemsList.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "button")]
        [JsonProperty(Order = 1)]
        public ButtonCard Button { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (FooterCard)obj;
                return
                    this.Button.Equals(that.Button);
            }

            return false;
        }
    }
}
