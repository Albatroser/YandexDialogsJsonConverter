using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class SessionTest
    {
        [TestMethod]
        public void Error()
        {

            // Arrang
            string excectedText1 = "SessionId " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.Session.SessionId";

            string excectedText3 = "MessageId максимум 8 символов. Факт 9 знаков: 100000000";
            string excectedText4 = "YandexDialogsJsonConverter.Response.Session.MessageId";

            string excectedText5 = "UserId " + TestString.TextErrorMes6470;
            string excectedText6 = "YandexDialogsJsonConverter.Response.Session.UserId";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.Session session
                = new YandexDialogsJsonConverter.Response.Сheck.Session(
                    new YandexDialogsJsonConverter.Response.Session(TestString.Text70,100000000, TestString.Text70));
            var v = session.QueueError.Dequeue();
            var v1 = session.QueueError.Dequeue();
            var v2 = session.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v1.ErrorText);
            Assert.AreEqual(excectedText2, v1.OdjName);

            Assert.AreEqual(excectedText3, v.ErrorText);
            Assert.AreEqual(excectedText4, v.OdjName);

            Assert.AreEqual(excectedText5, v2.ErrorText);
            Assert.AreEqual(excectedText6, v2.OdjName);
            Assert.AreEqual(true, session.Check);
        }

        [TestMethod]
        public void NotError()
        {

            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.Session session
              = new YandexDialogsJsonConverter.Response.Сheck.Session(
                  new YandexDialogsJsonConverter.Response.Session("TestString", 10000000, "TestString"));
            // Assert
            Assert.AreEqual(0, session.QueueError.Count);
            Assert.AreEqual(false, session.Check);
        }
    }
}
