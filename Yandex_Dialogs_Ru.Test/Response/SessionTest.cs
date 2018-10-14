using YandexDialogsJsonConverter.Response;
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

        [TestMethod]
        public void СreateSessionFor()
        {
            // Arrang
            string sessionId = "2eac4854-fce721f3-b845abba-20d60";
            int messageId = 4;
            string userId = "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC";
            // Act
            for (int i = 0; i < 1000000000; i++)
            {
                Session Session1 = new Session(sessionId, i, userId);
            }
            Session Session = new Session(sessionId, messageId, userId);

            // Assert
            Assert.AreEqual(sessionId, Session.SessionId);
            Assert.AreEqual(messageId, Session.MessageId);
            Assert.AreEqual(userId, Session.UserId);
        }
        [TestMethod]
        public void СreateSessionClassOldFor()
        {
            // Arrang
            string sessionId = "2eac4854-fce721f3-b845abba-20d60";
            int messageId = 4;
            string userId = "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC";
            // Act
            for (int i = 0; i < 1000000000; i++)
            {
                SessionClassOld Session1 = new SessionClassOld { SessionId= sessionId, MessageId = i, UserId = userId };
            }
            SessionClassOld Session = new SessionClassOld { SessionId = sessionId, MessageId = messageId, UserId = userId };

            // Assert
            Assert.AreEqual(sessionId, Session.SessionId);
            Assert.AreEqual(messageId, Session.MessageId);
            Assert.AreEqual(userId, Session.UserId);
        }
    }
}
