using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    /// <summary>
    /// Проверка Response на соответствие требованиям яндекс.диалоги
    /// </summary>
    public class ResponseObject : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ResponseObject response;

        public ResponseObject(YandexDialogsJsonConverter.Response.ResponseObject responseSet)
        {
            response = responseSet;
            StringCheckLimitLength("Text", response, 1024);
            StringCheckLimitLength("Tts", response, 1024); 
            //response.Buttons;

            if (response.Card is YandexDialogsJsonConverter.Response.ImageCard.BigImageCard)
            {
                BigImageCard bigImageCard = new BigImageCard((YandexDialogsJsonConverter.Response.ImageCard.BigImageCard)response.Card);
                AddQueueError(bigImageCard);
            };
            if (response.Card is YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList)
            {
                ItemsCardList itemsCardList = new ItemsCardList((YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList)response.Card);
                AddQueueError(itemsCardList);
            };

            ButtonsCheck();

        }


        void ButtonsCheck()
        {
            if (response.Buttons != null)
            {
                for (int i = 0; i < response.Buttons.Length; i++)
                {
                    Button buttonCard = new Button(response.Buttons[i]);
                    AddQueueError(buttonCard);
                }
            }
        }

    }
}
