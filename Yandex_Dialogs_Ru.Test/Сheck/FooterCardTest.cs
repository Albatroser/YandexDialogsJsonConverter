using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class FooterCardTest
    {
        [TestMethod]
        public void ToError()
        {

            // Arrang
            string excectedText1 = "Text " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard.Text";
            string excectedText3 = "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе";
            string excectedText4 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.FooterCard footerCard
                = new YandexDialogsJsonConverter.Response.Сheck.FooterCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard(
                        TestString.Text70,
                        new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "UrlSet", new { })));
            var v = footerCard.QueueError.Dequeue();
            var v1 = footerCard.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(excectedText3, v1.ErrorText);
            Assert.AreEqual(excectedText4, v1.OdjName);
            Assert.AreEqual(true, footerCard.Check);
        }

        [TestMethod]
        public void NotError()
        {

            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.FooterCard footerCard
                = new YandexDialogsJsonConverter.Response.Сheck.FooterCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard(
                        "TestString",
                        new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { })));

            // Assert
            Assert.AreEqual(0, footerCard.QueueError.Count);
            Assert.AreEqual(false, footerCard.Check);
        }
    }
}
