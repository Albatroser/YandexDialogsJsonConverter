using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class ItemsCardList : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList itemsCardList;

        public ItemsCardList(YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList itemsCardListSet)
        {
            itemsCardList = itemsCardListSet;

            FooterCard footerCard = new FooterCard(itemsCardList.Footer);
            AddQueueError(footerCard);

            ItemsCheck();

            HeaderCard headerCard = new HeaderCard(itemsCardList.Header);
            AddQueueError(headerCard);

        }


        void ItemsCheck()
        {
            if (itemsCardList.Items.Length < 1)
            { ErrorSet(itemsCardList, "Items должно быть не меньше 1 и не больше 5"); }

            if (itemsCardList.Items.Length > 5)
            { ErrorSet(itemsCardList, "Items должно быть не меньше 1 и не больше 5"); }

            for (int i = 0; i < itemsCardList.Items.Length; i++)
            {
                CardItems cardItems = new CardItems(itemsCardList.Items[i]);
                AddQueueError(cardItems);

            }
        }
    }
}
