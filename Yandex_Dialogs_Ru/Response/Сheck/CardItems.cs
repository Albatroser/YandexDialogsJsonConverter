using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class CardItems : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems cardItems;
        public CardItems(YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems cardItemsSet)
        {
            cardItems = cardItemsSet;
            StringCheckLimitLength("Title", cardItems, 64);    

            ButtonCard buttonCard = new ButtonCard(cardItems.Button);
            AddQueueError(buttonCard);
        }
    }
}
