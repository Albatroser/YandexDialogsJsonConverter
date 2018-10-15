using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using YandexDialogsJsonConverter.ImageCard.CardBase;

namespace YandexDialogsJsonConverter.ImageCard
{
    [DataContract]
    public struct BigImageCard : ICard
    {
        /// <summary>
        /// Идентификатор изображения, который возвращается в ответ на запрос загрузки.
        /// <para> Необходимо указывать для карточки типа BigImage, для типа ItemsList игнорируется.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "image_id")]
        [JsonProperty(Order = 1)]
        public string Image_id { get; set; }

        /// <summary>
        /// Заголовок для изображения.
        /// <para>Игнорируется для карточки типа ItemsList.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "title")]
        [JsonProperty(Order = 2)]
        public string Title { get; set; }

        /// <summary>
        ///  Описание изображения.
        /// <para> Игнорируется для карточки типа ItemsList.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "description")]
        [JsonProperty(Order = 3)]
        public string Description { get; set; }

        /// <summary>
        /// Свойства изображения, на которое можно нажать.
        /// <para> Игнорируется для карточки типа ItemsList.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "button")]
        [JsonProperty(Order = 4)]
        public ButtonCard Button { get; set; }


        /// <summary>
        /// Тип карточки. 
        /// <para>Требуемый формат ответа зависит от типа карточки.</para>
        /// </summary>
        [DataMember(Name = "type")]
        [JsonProperty(Order = 0)]
        public TypeCardEnum TypeCard { get { return TypeCardEnum.BigImage; } }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (BigImageCard)obj;
                return
                    this.TypeCard.Equals(that.TypeCard) &&
                    this.Button.Equals(that.Button);
            }

            return false;
        }
    }
}
