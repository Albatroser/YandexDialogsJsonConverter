using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class HeaderCard : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard headerCard;
        public HeaderCard(YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard headerCardSet)
        {
            headerCard = headerCardSet;

            StringCheckLimitLength("Text", headerCard, 64);
        }


    }
}
