using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.ImageCard.CardBase
{
    public interface ICard
    {
        /// <summary>
        /// Тип карточки. 
        /// <para>Требуемый формат ответа зависит от типа карточки.</para>
        /// </summary>

        TypeCardEnum TypeCard { get; }
    }
}
