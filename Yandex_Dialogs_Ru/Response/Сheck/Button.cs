using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class Button : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.Buttons buttons;
        public Button(YandexDialogsJsonConverter.Response.Buttons buttonsSet)
        {
            buttons = buttonsSet;
            StringCheckLimitLength("Title", buttons, 64);
            UrlCheck();
            PayloadCheck();
        }

        protected void UrlCheck()
        {
            StringCheckLimitLength("Url", buttons, 1024);

            System.Uri uriResult;
            if (!Uri.TryCreate(buttons.Url, UriKind.Absolute, out uriResult))
            { ErrorSet(buttons, "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе"); }

        }

        protected void PayloadCheck()
        {
            string text = Infrastructure.JsonConvert.SerializeJSon(buttons.Payload);

            byte[] fv = Encoding.UTF8.GetBytes(text);

            if (fv.Length > 4096) ErrorSet(buttons, "Payload - Максимум 4096 байт. Факт: " + fv.Length.ToString());
          //  StringCheckLimitLength("Payload", buttons, text, 4096);

        }
    }
}
