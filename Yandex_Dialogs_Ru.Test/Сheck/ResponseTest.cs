using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class ResponseTest
    {
        [TestMethod]
        public void NotError()
        {

            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.Response response
              = new YandexDialogsJsonConverter.Response.Сheck.Response(
                  new YandexDialogsJsonConverter.Response.Response(
                      new YandexDialogsJsonConverter.Response.ResponseObject(
                          "", 
                          false, 
                          "", 
                          new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                              "", 
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard(
                                  "TextSet", 
                                  "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", 
                                  new { }), 
                              "TestString", 
                              ""), 
                          new YandexDialogsJsonConverter.Response.Buttons[] 
                          {
                              new YandexDialogsJsonConverter.Response.Buttons(
                                  "TestString",
                                  new { }, 
                                  "https://www.youtube.com/watch?v=CT_p236O5mI",
                                  true) }),
                      new YandexDialogsJsonConverter.Response.Session("TestString", 10000000, "TestString")));
            // Assert
            Assert.AreEqual(0, response.QueueError.Count);
            Assert.AreEqual(false, response.Check);
        }

        [TestMethod]
        public void ErrorResponseObject()
        {

            // Arrang
            string excectedText1 = "Text " + TestString.TextErrorMes10241500;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ResponseObject.Text";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.Response response
              = new YandexDialogsJsonConverter.Response.Сheck.Response(
                  new YandexDialogsJsonConverter.Response.Response(
                      new YandexDialogsJsonConverter.Response.ResponseObject(
                           TestString.Text1500,
                          false,
                          "",
                          new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard(
                                  "TextSet",
                                  "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response",
                                  new { }),
                              "TestString",
                              ""),
                          new YandexDialogsJsonConverter.Response.Buttons[]
                          {
                              new YandexDialogsJsonConverter.Response.Buttons(
                                  "TestString",
                                  new { },
                                  "https://www.youtube.com/watch?v=CT_p236O5mI",
                                  true) }),
                      new YandexDialogsJsonConverter.Response.Session("TestString", 10000000, "TestString")));
            var v = response.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, response.Check);
        }

        [TestMethod]
        public void ErrorSession()
        {

            // Arrang
            string excectedText1 = "SessionId " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.Session.SessionId";

            string excectedText3 = "MessageId максимум 8 символов. Факт 9 знаков: 100000000";
            string excectedText4 = "YandexDialogsJsonConverter.Response.Session.MessageId";

            string excectedText5 = "UserId " + TestString.TextErrorMes6470;
            string excectedText6 = "YandexDialogsJsonConverter.Response.Session.UserId";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.Response response
              = new YandexDialogsJsonConverter.Response.Сheck.Response(
                  new YandexDialogsJsonConverter.Response.Response(
                      new YandexDialogsJsonConverter.Response.ResponseObject(
                          "",
                          false,
                          "",
                          new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard(
                                  "TextSet",
                                  "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response",
                                  new { }),
                              "TestString",
                              ""),
                          new YandexDialogsJsonConverter.Response.Buttons[]
                          {
                              new YandexDialogsJsonConverter.Response.Buttons(
                                  "TestString",
                                  new { },
                                  "https://www.youtube.com/watch?v=CT_p236O5mI",
                                  true) }),
                      new YandexDialogsJsonConverter.Response.Session(TestString.Text70, 100000000, TestString.Text70)));
            var v = response.QueueError.Dequeue();
            var v1 = response.QueueError.Dequeue();
            var v2 = response.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v1.ErrorText);
            Assert.AreEqual(excectedText2, v1.OdjName);

            Assert.AreEqual(excectedText3, v.ErrorText);
            Assert.AreEqual(excectedText4, v.OdjName);

            Assert.AreEqual(excectedText5, v2.ErrorText);
            Assert.AreEqual(excectedText6, v2.OdjName);
            Assert.AreEqual(true, response.Check);
        }
    }
}
