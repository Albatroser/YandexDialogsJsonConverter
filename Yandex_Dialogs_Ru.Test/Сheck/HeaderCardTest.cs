using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class HeaderCardTest
    {
        [TestMethod]
        public void Error()
        {

            // Arrang
            string excectedText1 = "Text " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard.Text";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.HeaderCard headerCard
                = new YandexDialogsJsonConverter.Response.Сheck.HeaderCard(
                    new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard(TestString.Text70));
            var v = headerCard.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, headerCard.Check);
        }

        [TestMethod]
        public void NotError()
        {

            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.HeaderCard headerCard
       = new YandexDialogsJsonConverter.Response.Сheck.HeaderCard(
           new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard("Test"));
            // Assert
            Assert.AreEqual(0, headerCard.QueueError.Count);
            Assert.AreEqual(false, headerCard.Check);
        }
    }
}
