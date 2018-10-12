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
    public class BigImageCard: CardItems, ICard
    {
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
                var that = obj as BigImageCard;
                return
                    this.TypeCard == that.TypeCard &&
                    this.Button == that.Button;
            }

            return false;
        }
    }
}
