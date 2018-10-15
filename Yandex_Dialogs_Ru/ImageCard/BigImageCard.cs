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
        string imageId, title, description;
        ButtonCard button;
        /// <summary>
        /// Описание карточки — сообщения с поддержкой изображений.
        ///<para>Если приложению удается отобразить карточку для пользователя, свойство response.text не используется.</para>
        /// </summary>
        /// <param name="ImageIdSet">  Идентификатор изображения, который возвращается в ответ на запрос загрузки.
        /// <para> Необходимо указывать </para></param>
        /// <param name="ButtonSet"> Свойства изображения, на которое можно нажать.  </param>
        /// <param name="TitleSet">Заголовок для изображения.</param>
        /// <param name="DescriptionSet">Описание изображения.</param>
        public BigImageCard(string ImageIdSet, ButtonCard ButtonSet, string TitleSet = null, string DescriptionSet = null)
        {
            imageId = ImageIdSet;
            title = TitleSet;
            description = DescriptionSet;
            button = ButtonSet;
        }



        /// <summary>
        /// Идентификатор изображения, который возвращается в ответ на запрос загрузки.
        /// <para> Необходимо указывать </para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "image_id")]
        [JsonProperty(Order = 1)]
        public string Image_id { get { return imageId; } }

        /// <summary>
        /// Заголовок для изображения.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "title")]
        [JsonProperty(Order = 2)]
        public string Title { get { return title; } }

        /// <summary>
        ///  Описание изображения.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "description")]
        [JsonProperty(Order = 3)]
        public string Description { get { return description; } }

        /// <summary>
        /// Свойства изображения, на которое можно нажать.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "button")]
        [JsonProperty(Order = 4)]
        public ButtonCard Button { get { return button; } }


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
