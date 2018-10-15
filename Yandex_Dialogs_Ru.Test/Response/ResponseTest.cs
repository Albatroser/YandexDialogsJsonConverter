using YandexDialogsJsonConverter.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Response
{
    [TestClass]
    public class ResponseTest
    {
        [TestMethod]
        public void СreateResponse()
        {
            // Arrang
            string Text = "2eac4854-fce721f3-b845abba-20d60";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response(Text);
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(false, Response.EndSession);
        }
        [TestMethod]
        public void СreateResponse_EndSession_true()
        {
            // Arrang
            string Text = "2eac4854-fce721f3-b845abba-20d60";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response(Text, true, null, null, null, true);
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(true, Response.EndSession);
        }
        [TestMethod]
        public void СreateResponse_Text_isnull()
        {
            // Arrang
            string Text = "Что-то пошло не так.";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response(null);
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(false, Response.EndSession);
        }
        [TestMethod]
        public void СreateResponse_Text_()
        {
            // Arrang
            string expectedText = "Что-то пошло не так.";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response("");
            // Assert
            Assert.AreEqual(expectedText, Response.Text);
            Assert.AreEqual(false, Response.EndSession);
        }
        [TestMethod]
        public void СreateResponse_Text_1024()
        {
            // Arrang
            string Text = "Текст, который следует показать и сказать пользователю. Максимум 1024 символа. Не должен быть пустым. Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку(свойство response.card). На устройствах, которые поддерживают только голосовое общение с навыком, это будет происходить каждый раз, когда навык присылает карточку в ответе.  В тексте ответа можно указать переводы строк последовательностью «\n», например: \"Отдых напрасен. Дорога крута.\nВечер прекрасен. Стучу в ворота.\" Текст, который следует показать и сказать пользователю. Максимум 1024 символа. Не должен быть пустым. Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку(свойство response.card). На устройствах, которые поддерживают только голосовое общение с навыком, это будет происходить каждый раз, когда навык присылает карточку в ответе.  В тексте ответа можно указать переводы строк последовательностью «\n», например: \"Отдых напрасен. Дорога крута.\nВечер прекрасен. Стучу в ворота.\"";
            string expectedText = "Текст, который следует показать и сказать пользователю. Максимум 1024 символа. Не должен быть пустым. Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку(свойство response.card). На устройствах, которые поддерживают только голосовое общение с навыком, это будет происходить каждый раз, когда навык присылает карточку в ответе.  В тексте ответа можно указать переводы строк последовательностью «\n», например: \"Отдых напрасен. Дорога крута.\nВечер прекрасен. Стучу в ворота.\" Текст, который следует показать и сказать пользователю. Максимум 1024 символа. Не должен быть пустым. Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку(свойство response.card). На устройствах, которые поддерживают только голосовое общение с навыком, это будет происходить каждый раз, когда навык присылает карточку в ответе.  В тексте ответа можно указать переводы строк последовательностью «\n», например: \"Отдых напрасен. Дорога крута.\nВечер прекрасен. Стучу в ворота.";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response(Text);
            // Assert
            Assert.AreEqual(expectedText, Response.Text);
            Assert.AreEqual(false, Response.EndSession);
        }

        [TestMethod]
        public void СreateResponseFor()
        {
            // Arrang
            string Text = "2eac4854-fce721f3-b845abba-20d60";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response(Text);
            for (int i = 0; i < 1000000000; i++)
            { Response = new YandexDialogsJsonConverter.Response.Response(Text); }
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(false, Response.EndSession);
        }
        [TestMethod]
        public void СreateResponseFor_NoControl()
        {
            // Arrang
            string Text = "2eac4854-fce721f3-b845abba-20d60";
            // Act
            YandexDialogsJsonConverter.Response.Response Response = new
                YandexDialogsJsonConverter.Response.Response(Text);
            for (int i = 0; i < 1000000000; i++)
            { Response = new YandexDialogsJsonConverter.Response.Response(Text, true); }
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(false, Response.EndSession);
        }
    }
}
