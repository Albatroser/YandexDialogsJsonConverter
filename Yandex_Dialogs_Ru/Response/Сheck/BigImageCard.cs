using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class BigImageCard : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ImageCard.BigImageCard bigImageCard;

        public BigImageCard(YandexDialogsJsonConverter.Response.ImageCard.BigImageCard bigImageCardSet)
        {
            bigImageCard = bigImageCardSet;

            StringCheckNotNullLimitLength("Title", bigImageCard, 64);

            ButtonCard buttonCard = new ButtonCard(bigImageCard.Button);
            AddQueueError(buttonCard);
        }

    }
}
