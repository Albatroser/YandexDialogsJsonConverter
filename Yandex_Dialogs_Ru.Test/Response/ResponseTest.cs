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
            YandexDialogsJsonConverter.Response.ResponseObject Response = new
                YandexDialogsJsonConverter.Response.ResponseObject(Text);
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
            YandexDialogsJsonConverter.Response.ResponseObject Response = new
                YandexDialogsJsonConverter.Response.ResponseObject(Text, true);
            // Assert
            Assert.AreEqual(Text, Response.Text);
            Assert.AreEqual(true, Response.EndSession);
        }
       
        
    }
}
