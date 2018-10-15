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
    public struct CardItems
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

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (CardItems)obj;
                return
                    this.Image_id == that.Image_id &&
                    this.Title == that.Title &&
                    this.Description == that.Description;
            }

            return false;
        }
    }
}
