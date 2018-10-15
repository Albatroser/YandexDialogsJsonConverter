using YandexDialogsJsonConverter.Response;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Response
{
    [TestClass]
    public class ButtonsTest
    {
        [TestMethod]
        public void СreateButtons()
        {
            // Arrang
            string Title = "Надпись на кнопке";
            object Payload = new object();
            bool Hide = true;
            string Url = "https://example.com/";
            // Act
            Buttons Buttons = new Buttons(Title, Payload, Url, Hide);
            // Assert
            Assert.AreEqual(Title, Buttons.Title);
            Assert.AreEqual(Url, Buttons.Url);
            Assert.AreEqual(Payload, Buttons.Payload);
            Assert.AreEqual(Hide, Buttons.Hide);
        }
        [TestMethod]
        public void СreateButtons_Url_isnull()
        {
            // Arrang
            string Title = "Надпись на кнопке";
            object Payload = new object();
            bool Hide = true;
            string Url = null;
            // Act
            Buttons Buttons = new Buttons(Title, Payload, Url, Hide);
            // Assert
            Assert.AreEqual(Title, Buttons.Title);
            Assert.AreEqual(Url, Buttons.Url);
            Assert.AreEqual(Payload, Buttons.Payload);
            Assert.AreEqual(Hide, Buttons.Hide);
        }

        [TestMethod]
        public void СreateButtonsFor()
        {
            // Arrang
            string Title = "Надпись на кнопке";
            object Payload = new object();
            bool Hide = true;
            string Url = "https://example.com/";
            // Act
            for (int i = 0; i < 1000000000; i++)
            {
                Buttons Buttons1 = new Buttons(Title, Payload, Url, Hide);
            }
            Buttons Buttons = new Buttons(Title, Payload, Url, Hide);

            // Assert
            Assert.AreEqual(Title, Buttons.Title);
            Assert.AreEqual(Url, Buttons.Url);
            Assert.AreEqual(Payload, Buttons.Payload);
            Assert.AreEqual(Hide, Buttons.Hide);
        }
    }
}
