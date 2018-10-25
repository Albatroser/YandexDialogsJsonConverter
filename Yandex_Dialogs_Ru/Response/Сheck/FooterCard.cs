using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class FooterCard : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard footerCard;
        public  FooterCard(YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard footerCardSet)
        {
            footerCard = footerCardSet;

            StringCheckLimitLength("Text", footerCard, 64);

            ButtonCard buttonCard = new ButtonCard(footerCard.Button);
            AddQueueError(buttonCard);
        }


    }
}
