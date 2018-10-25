using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class ErrorCheckingTest : YandexDialogsJsonConverter.Response.Сheck.ErrorChecking
    {
        [TestMethod]
        public void StringCheckNotNullLimitLength()
        {
            // Arrang
            object obj = new { SessionId = "1234567890" };
            // Act
            StringCheckNotNullLimitLength("SessionId", obj, 10);

            // Assert
            Assert.AreEqual(0, QueueError.Count);
            Assert.AreEqual(false, Check);
        }

        [TestMethod]
        public void StringCheckNotNullLimitLength1()
        {
            // Arrang
            object obj = new { Text = "12345678900" };

            string excectedText = "Text максимум 10 символов. Факт 11 знаков: 12345678900";
            string excectedText2 = obj.GetType().ToString() + ".Text";
            // Act
            StringCheckNotNullLimitLength("Text", obj, 10);

            var v = QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, Check);
        }

        [TestMethod]
        public void StringCheckNotNullLimitLength2()
        {
            // Arrang
            object obj = new { SessionId = "12345678900" };

            string excectedText = "SessionId максимум 10 символов. Факт 15 знаков: Bolt12345678900";
            string excectedText2 = obj.GetType().ToString() + ".SessionId";
            // Act
            StringCheckNotNullLimitLength("SessionId", obj, "Bolt12345678900", 10);

            var v = QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, Check);
        }

        [TestMethod]
        public void StringCheckNotNullLimitLength3()
        {
            // Arrang
            object obj = new { SessionId = "" };

            string excectedText = "SessionId Не должен быть пустым.";
            string excectedText2 = obj.GetType().ToString() + ".SessionId";
            // Act
            StringCheckNotNullLimitLength("SessionId", obj, 10);

            var v = QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, Check);
        }

        [TestMethod]
        public void StringCheckNotNullLimitLength4()
        {
            // Arrang
            object obj = new { SessionId = "\n" };

            string excectedText = "SessionId Не должен быть пустым.";
            string excectedText2 = obj.GetType().ToString() + ".SessionId";
            // Act
            StringCheckNotNullLimitLength("SessionId", obj, 10);

            var v = QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, Check);
        }

        [TestMethod]
        public void StringCheckNotNullLimitLength5()
        {
            // Arrang
            object obj = new { SessionId = "\n", Text="1234567890" };

            string excectedText = "SessionId Не должен быть пустым.";
            string excectedText2 = obj.GetType().ToString() + ".SessionId";
            string excectedText3 = "Text максимум 5 символов. Факт 10 знаков: 1234567890";
            string excectedText4 = obj.GetType().ToString() + ".Text";
            // Act
            StringCheckNotNullLimitLength("SessionId", obj, 10);
            StringCheckNotNullLimitLength("Text", obj, 5);

            var v = QueueError.Dequeue();
            var v1 = QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(excectedText3, v1.ErrorText);
            Assert.AreEqual(excectedText4, v1.OdjName);
            Assert.AreEqual(true, Check);
        }

        [TestMethod]
        public void AddQueueError()
        {
            // Arrang
            YandexDialogsJsonConverter.Response.Сheck.ErrorChecking errorChecking = new YandexDialogsJsonConverter.Response.Сheck.ErrorChecking();
            string excectedText = "Test2";
            string excectedText2 = "Test1";
            // Act
            errorChecking.QueueError.Enqueue(new YandexDialogsJsonConverter.Response.Сheck.Error("Test1", "Test2"));
            errorChecking.Check = true;
            AddQueueError(errorChecking);
            var v = QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, Check);
        }


    }
}
