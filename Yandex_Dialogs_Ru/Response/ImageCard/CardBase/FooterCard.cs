using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.ImageCard.CardBase
{
    [DataContract]
    public struct FooterCard
    {
        string text;
        ButtonCard button;
        /// <summary>
        /// Кнопки под галереей изображений.
        /// </summary>
        /// <param name="TextSet">Текст заголовка, обязателен, если передается свойство header.Максимум 64 символа.</param>
        public FooterCard(string TextSet, ButtonCard ButtonSet)
        {
            text = TextSet;
            button = ButtonSet;
        }


        /// <summary>
        /// Текст заголовка, обязателен, если передается свойство header.Максимум 64 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "text")]
        [JsonProperty(Order = 0)]
        public string Text { get { return text; } }


        /// <summary>
        /// Дополнительная кнопка для галереи изображений.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "button")]
        [JsonProperty(Order = 1)]
        public ButtonCard Button { get { return button; } }

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
