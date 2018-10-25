using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YandexDialogsJsonConverter.Response;
using YandexDialogsJsonConverter.Response.Сheck;

namespace YandexDialogsJsonConverterTest
{
    //[TestClass]
    //public class LoadTest
    //{
    //    [TestMethod]
    //    public void SetResponseCheck_For()
    //    {
    //        // Arrang
    //        string excectedText1 = "MessageId максимум 8 символов. Факт 9 знаков: 123456789";
    //        string excectedText2 = "YandexDialogsJsonConverter.Response.Session.MessageId";



    //        YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
    //        string jsonExpected = "{\"response\": {\"text\": \"Здравствуйте! Это мы, хороводоведы.\",\"tts\": \"Здравствуйте! Это мы, хоров+одо в+еды.\", \"buttons\": [ { \"title\": \"Надпись на кнопке\", \"payload\": {}, \"url\": \"https://example.com/\", \"hide\": true } ], \"end_session\": false  }, \"session\": { \"session_id\": \"2eac4854-fce721f3-b845abba-20d60\", \"message_id\": 4, \"user_id\": \"AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC\"  },  \"version\": \"1.0\"}";

    //        YandexDialogsJsonConverter.Response.Response value = new YandexDialogsJsonConverter.Response.Response(
    //            new YandexDialogsJsonConverter.Response.ResponseObject("Здравствуйте! Это мы, хороводоведы.", false,
    //            "Здравствуйте! Это мы, хоров+одо в+еды.", null, new YandexDialogsJsonConverter.Response.Buttons[]{
    //                    new YandexDialogsJsonConverter.Response.Buttons ( "Надпись на кнопке", new object(),"https://example.com/", true)
    //            }),
    //            new YandexDialogsJsonConverter.Response.Session
    //            ("2eac4854-fce721f3-b845abba-20d60", 123456789, "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC")
    //        );

    //        Error[] error;
    //        // Act
    //        string json = api.SetResponseCheck(value, out error);
    //        for (int i = 0; i < 1000000; i++)
    //        {
    //            json = api.SetResponseCheck(value, out error);
    //        }
    //        string jsonExpected1 = jsonExpected.Replace(" ", "");

    //        var v = error[0];
    //        // Assert
    //        Assert.IsNull(json);
    //        Assert.AreEqual(excectedText1, v.ErrorText);
    //        Assert.AreEqual(excectedText2, v.OdjName);
    //    }

    //    [TestMethod]
    //    public void SetResponse_For()
    //    {
    //        // Arrang
    //        YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
    //        string jsonExpected = "{\"response\": {\"text\": \"Здравствуйте! Это мы, хороводоведы.\",\"tts\": \"Здравствуйте! Это мы, хоров+одо в+еды.\", \"buttons\": [ { \"title\": \"Надпись на кнопке\", \"payload\": {}, \"url\": \"https://example.com/\", \"hide\": true } ], \"end_session\": false  }, \"session\": { \"session_id\": \"2eac4854-fce721f3-b845abba-20d60\", \"message_id\": 4, \"user_id\": \"AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC\"  },  \"version\": \"1.0\"}";

    //        YandexDialogsJsonConverter.Response.Response value = new YandexDialogsJsonConverter.Response.Response(
    //            new YandexDialogsJsonConverter.Response.ResponseObject("Здравствуйте! Это мы, хороводоведы.", false,
    //            "Здравствуйте! Это мы, хоров+одо в+еды.", null, new YandexDialogsJsonConverter.Response.Buttons[]{
    //                    new YandexDialogsJsonConverter.Response.Buttons ( "Надпись на кнопке", new object(),"https://example.com/", true)
    //            }),
    //            new YandexDialogsJsonConverter.Response.Session
    //            ("2eac4854-fce721f3-b845abba-20d60", 4, "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC")
    //        );

    //        // Act
    //        string json = api.SetResponse(value);
    //        for (int i = 0; i < 1000000; i++)
    //        {
    //            json = api.SetResponse(value);
    //        }
    //        string json1 = json.Replace(" ", "");
    //        string jsonExpected1 = jsonExpected.Replace(" ", "");
    //        bool s = json1 == jsonExpected1;
    //        // Assert
    //        Assert.AreEqual(jsonExpected1, json1, true);
    //    }

    //    [TestMethod]
    //    public void СreateResponseFor()
    //    {
    //        // Arrang
    //        string Text = "2eac4854-fce721f3-b845abba-20d60";
    //        // Act
    //        YandexDialogsJsonConverter.Response.ResponseObject Response = new
    //            YandexDialogsJsonConverter.Response.ResponseObject(Text);
    //        for (int i = 0; i < 1000000000; i++)
    //        { Response = new YandexDialogsJsonConverter.Response.ResponseObject(Text); }
    //        // Assert
    //        Assert.AreEqual(Text, Response.Text);
    //        Assert.AreEqual(false, Response.EndSession);
    //    }
        
    //    [TestMethod]
    //    public void СreateButtonsFor()
    //    {
    //        // Arrang
    //        string Title = "Надпись на кнопке";
    //        object Payload = new object();
    //        bool Hide = true;
    //        string Url = "https://example.com/";
    //        // Act
    //        for (int i = 0; i < 1000000000; i++)
    //        {
    //            Buttons Buttons1 = new Buttons(Title, Payload, Url, Hide);
    //        }
    //        Buttons Buttons = new Buttons(Title, Payload, Url, Hide);

    //        // Assert
    //        Assert.AreEqual(Title, Buttons.Title);
    //        Assert.AreEqual(Url, Buttons.Url);
    //        Assert.AreEqual(Payload, Buttons.Payload);
    //        Assert.AreEqual(Hide, Buttons.Hide);
    //    }

    //    [TestMethod]
    //    public void СreateSessionFor()
    //    {
    //        // Arrang
    //        string sessionId = "2eac4854-fce721f3-b845abba-20d60";
    //        int messageId = 4;
    //        string userId = "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC";
    //        // Act
    //        for (int i = 0; i < 1000000000; i++)
    //        {
    //            YandexDialogsJsonConverter.Response.Session Session1 = new YandexDialogsJsonConverter.Response.Session(sessionId, i, userId);
    //        }
    //        YandexDialogsJsonConverter.Response.Session Session = new YandexDialogsJsonConverter.Response.Session(sessionId, messageId, userId);

    //        // Assert
    //        Assert.AreEqual(sessionId, Session.SessionId);
    //        Assert.AreEqual(messageId, Session.MessageId);
    //        Assert.AreEqual(userId, Session.UserId);
    //    }
    //}
}
