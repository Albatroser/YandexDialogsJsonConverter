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
    public class FooterCard : HeaderCard
    {
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
                var that = obj as FooterCard;
                return
                    this.Button == that.Button;
            }

            return false;
        }
    }
}
