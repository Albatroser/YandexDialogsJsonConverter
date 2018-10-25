using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class ButtonCardTest

    //: YandexDialogsJsonConverter.Response.Сheck.ButtonCard
    {
        [TestMethod]
        public void UrlError()
        {
            // Arrang
            string excectedText = "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе";
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ButtonCard buttonCard =
                new YandexDialogsJsonConverter.Response.Сheck.ButtonCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard
                    (
                        "TextSet",
                        "UrlSet",
                        new { }
                        ));
            var v = buttonCard.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, buttonCard.Check);
        }

        [TestMethod]
        public void UrlNotError()
        {
            // Arrang

            // Act
            YandexDialogsJsonConverter.Response.Сheck.ButtonCard buttonCard =
                new YandexDialogsJsonConverter.Response.Сheck.ButtonCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard
                    (
                        "TextSet",
                        "https://www.youtube.com/watch?v=CT_p236O5mI",
                        new { }
                        ));
            // Assert
            Assert.AreEqual(0, buttonCard.QueueError.Count);
            Assert.AreEqual(false, buttonCard.Check);
        }

        [TestMethod]
        public void TextError()
        {
            // Arrang
            string excectedText = "Text "+ TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard.Text";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ButtonCard buttonCard =
                new YandexDialogsJsonConverter.Response.Сheck.ButtonCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard
                    (
                         TestString.Text70,
                        "https://www.youtube.com/watch?v=CT_p236O5mI",
                        new { }
                        ));
            var v = buttonCard.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, buttonCard.Check);
        }
    }
}
