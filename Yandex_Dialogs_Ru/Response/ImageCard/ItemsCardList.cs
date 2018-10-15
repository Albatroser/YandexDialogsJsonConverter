using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using YandexDialogsJsonConverter.Response.ImageCard.CardBase;

namespace YandexDialogsJsonConverter.Response.ImageCard
{
    [DataContract]
    public struct ItemsCardList : ICard
    {
        HeaderCard header; CardItems[] items; FooterCard footer;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="HeaderSet">
        /// Заголовок галереи изображений.
        /// </param>
        /// <param name="ItemsSet">
        /// Набор изображений для галереи — не меньше 1, не больше 5.
        /// </param>
        /// <param name="FooterSet">
        /// Кнопки под галереей изображений.
        /// </param>
        public ItemsCardList(HeaderCard HeaderSet, CardItems[] ItemsSet, FooterCard FooterSet)
        {
            header = HeaderSet;
            items = ItemsSet;
            footer = FooterSet;
        }


        /// <summary>
        /// Тип карточки. 
        /// <para>Требуемый формат ответа зависит от типа карточки.</para>
        /// </summary>
        [DataMember(Name = "type")]
        [JsonProperty(Order = 0)]
        public TypeCardEnum TypeCard { get { return TypeCardEnum.ItemsList; } }

        /// <summary>
        /// Заголовок галереи изображений.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "header")]
        [JsonProperty(Order = 1)]
        public HeaderCard Header { get { return header; } }

        /// <summary>
        /// Набор изображений для галереи — не меньше 1, не больше 5.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "items")]
        [JsonProperty(Order = 2)]
        public CardItems[] Items { get { return items; } }

        /// <summary>
        /// Кнопки под галереей изображений.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "footer")]
        [JsonProperty(Order = 3)]
        public FooterCard Footer { get { return footer; } }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (ItemsCardList)obj;
                return
                    this.TypeCard == that.TypeCard &&
                    this.Header.Equals(that.Header) &&
                    this.Footer.Equals(that.Footer) &&
                    this.Items == that.Items;
            }

            return false;
        }
    }
}
