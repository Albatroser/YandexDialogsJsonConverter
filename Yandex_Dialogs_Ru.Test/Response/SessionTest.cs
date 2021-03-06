﻿using YandexDialogsJsonConverter.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Response
{
    [TestClass]
    public class SessionTest
    {
        [TestMethod]
        public void СreateSession()
        {
            // Arrang
            string sessionId = "2eac4854-fce721f3-b845abba-20d60";
            int messageId = 4;
            string userId = "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC";
            // Act
            Session Session = new Session(sessionId, messageId, userId);
            // Assert
            Assert.AreEqual(sessionId, Session.SessionId);
            Assert.AreEqual(messageId, Session.MessageId);
            Assert.AreEqual(userId, Session.UserId);
        }


    }
}
