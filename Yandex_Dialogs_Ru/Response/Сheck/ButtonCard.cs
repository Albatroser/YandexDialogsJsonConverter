using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class ButtonCard : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard buttonCard;
        public ButtonCard(YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard buttonCardSet)
        {
            buttonCard = buttonCardSet;
            StringCheckLimitLength("Text", buttonCard, 64);
            UrlCheck();
            PayloadCheck();
        }

        protected void UrlCheck()
        {
            StringCheckLimitLength("Url", buttonCard, 1024);

            System.Uri uriResult;
            if (!Uri.TryCreate(buttonCard.Url, UriKind.Absolute, out uriResult))
            { ErrorSet(buttonCard, "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе"); }

        }

        protected void PayloadCheck()
        {
            string text = Infrastructure.JsonConvert.SerializeJSon(buttonCard.Payload);

            byte[] fv = Encoding.UTF8.GetBytes(text);

            if (fv.Length > 4096) ErrorSet(buttonCard, "Payload - Максимум 4096 байт. Факт: " + fv.Length.ToString());

        }
    }
}
