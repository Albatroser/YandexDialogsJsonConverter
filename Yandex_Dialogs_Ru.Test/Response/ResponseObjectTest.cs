using YandexDialogsJsonConverter.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Response
{
    [TestClass]
    public class ResponseObjectTest
    {
        [TestMethod]
        public void СreateResponse()
        {
            // Arrang
            YandexDialogsJsonConverter.Response.ResponseObject response = new YandexDialogsJsonConverter.Response.ResponseObject("Тест");
            Session session = new Session("SessionID", 4, "UserID");
            // Act
            YandexDialogsJsonConverter.Response.Response ResponseObject = new YandexDialogsJsonConverter.Response.Response(response, session);
            //// Assert
            Assert.AreEqual("SessionID", ResponseObject.Session.SessionId);
            Assert.AreEqual(4, ResponseObject.Session.MessageId);
            Assert.AreEqual("UserID", ResponseObject.Session.UserId);
            Assert.AreEqual("1.0", ResponseObject.Version);
            Assert.AreEqual("Тест", ResponseObject.ResponseObject.Text);
        }

        [TestMethod]
        public void СreateResponse2()
        {
            // Arrang
            YandexDialogsJsonConverter.Response.ResponseObject response = new YandexDialogsJsonConverter.Response.ResponseObject("Тест");
            Session session = new Session("SessionID", 4, "UserID");
            // Act
            YandexDialogsJsonConverter.Response.Response ResponseObject = new YandexDialogsJsonConverter.Response.Response(response, session, "2.0");
            //// Assert
            Assert.AreEqual("SessionID", ResponseObject.Session.SessionId);
            Assert.AreEqual(4, ResponseObject.Session.MessageId);
            Assert.AreEqual("UserID", ResponseObject.Session.UserId);
            Assert.AreEqual("2.0", ResponseObject.Version);
            Assert.AreEqual("Тест", ResponseObject.ResponseObject.Text);
        }
    }
}
