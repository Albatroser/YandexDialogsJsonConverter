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
                YandexDialogsJsonConverter.Response.Response(Text, true);
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(true, Response.EndSession);
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
    }
}
