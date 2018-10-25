using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class CardItemsTest
    {
        [TestMethod]
        public void ToError()
        {

            // Arrang
            string excectedText1 = "Title " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems.Title";
            string excectedText3 = "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе";
            string excectedText4 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.CardItems cardItems
                = new YandexDialogsJsonConverter.Response.Сheck.CardItems(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems("",
                        new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "UrlSet", new { }),
                        TestString.Text70,
                        ""));
            var v = cardItems.QueueError.Dequeue();
            var v1 = cardItems.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(excectedText3, v1.ErrorText);
            Assert.AreEqual(excectedText4, v1.OdjName);
            Assert.AreEqual(true, cardItems.Check);
        }

        [TestMethod]
        public void NotError()
        {

            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.CardItems cardItems
               = new YandexDialogsJsonConverter.Response.Сheck.CardItems(
                   new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems("",
                       new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                       "TestString",
                       ""));
            // Assert
            Assert.AreEqual(0, cardItems.QueueError.Count);
            Assert.AreEqual(false, cardItems.Check);
        }
    }
}
