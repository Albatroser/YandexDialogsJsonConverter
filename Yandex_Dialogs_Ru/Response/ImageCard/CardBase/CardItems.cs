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
    public struct CardItems
    {
        string imageId, title, description;
        ButtonCard button;
        /// <summary>
        /// Изображения для галереи
        /// </summary>
        /// <param name="ImageIdSet">  Идентификатор изображения, который возвращается в ответ на запрос загрузки.
        /// <para> Необходимо указывать </para></param>
        /// <param name="ButtonSet"> Свойства изображения, на которое можно нажать.  </param>
        /// <param name="TitleSet">Заголовок для изображения.</param>
        /// <param name="DescriptionSet">Описание изображения.</param>
        public CardItems(string ImageIdSet, ButtonCard ButtonSet, string TitleSet = null, string DescriptionSet = null)
        {
            imageId = ImageIdSet;
            title = TitleSet;
            description = DescriptionSet;
            button = ButtonSet;
        }


        /// <summary>
        /// Идентификатор изображения, который возвращается в ответ на запрос загрузки.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "image_id")]
        public string Image_id { get { return imageId; } }

        /// <summary>
        /// Заголовок для изображения.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "title")]
        public string Title { get { return title; } }

        /// <summary>
        ///  Описание изображения.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "description")]
        public string Description { get { return description; } }

        /// <summary>
        /// Свойства изображения, на которое можно нажать.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "button")]
        public ButtonCard Button { get { return button; } }

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
