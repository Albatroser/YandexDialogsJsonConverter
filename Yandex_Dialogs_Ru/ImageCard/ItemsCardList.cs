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
    public class ItemsCardList : ICard
    {
        /// <summary>
        /// Тип карточки. 
        /// <para>Требуемый формат ответа зависит от типа карточки.</para>
        /// </summary>
        [DataMember(Name = "type")]
        [JsonProperty(Order = 0)]
        public TypeCardEnum TypeCard { get { return TypeCardEnum.ItemsList; }  }
       
        /// <summary>
        /// Заголовок галереи изображений.
        /// <para> Игнорируется для карточки типа BigImage.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "header")]
        [JsonProperty(Order = 1)]
        public HeaderCard Header { get; set; }

        /// <summary>
        /// Набор изображений для галереи — не меньше 1, не больше 5.
        /// <para>Игнорируется для карточки типа BigImage.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "items")]
        [JsonProperty(Order = 2)]
        public CardItems[] Items { get; set; }

        /// <summary>
        /// Кнопки под галереей изображений.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "footer")]
        [JsonProperty(Order = 3)]
        public FooterCard Footer { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as ItemsCardList;
                return
                    this.TypeCard == that.TypeCard &&
                    this.Header == that.Header &&
                    this.Footer == that.Footer &&
                    this.Items == that.Items;
            }

            return false;
        }
    }
}
