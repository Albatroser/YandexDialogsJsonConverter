using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class BigImageCardTest
    {
        [TestMethod]
        public void ToError()
        {

            // Arrang
            string excectedText1 = "Title " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.BigImageCard.Title";
            string excectedText3 = "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе";
            string excectedText4 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.BigImageCard bigImageCard
                = new YandexDialogsJsonConverter.Response.Сheck.BigImageCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                        "",
                        new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "UrlSet", new { }), TestString.Text70,""));
            var v = bigImageCard.QueueError.Dequeue();
            var v1 = bigImageCard.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(excectedText3, v1.ErrorText);
            Assert.AreEqual(excectedText4, v1.OdjName);
            Assert.AreEqual(true, bigImageCard.Check);
        }

        [TestMethod]
        public void NotError()
        {

            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.BigImageCard bigImageCard
               = new YandexDialogsJsonConverter.Response.Сheck.BigImageCard(
                   new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                       "",
                       new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }), "TestString", "")
                       );

            // Assert
            Assert.AreEqual(0, bigImageCard.QueueError.Count);
            Assert.AreEqual(false, bigImageCard.Check);
        }
    }
}
