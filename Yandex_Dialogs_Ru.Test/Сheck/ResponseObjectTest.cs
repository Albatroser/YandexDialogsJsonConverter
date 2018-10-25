using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class ResponseObjectTest
    {
        [TestMethod]
        public void NotError1()
        {
            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      "", false, "",
                      new YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList(
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard("TestString"),
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems[]
                      {
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                      },
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { })))));

            // Assert
            Assert.AreEqual(0, responseObject.QueueError.Count);
            Assert.AreEqual(false, responseObject.Check);
        }

        [TestMethod]
        public void NotError2()
        {
            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      "", false, "",
                      new YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList(
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard("TestString"),
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems[]
                      {
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                      },
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { })))
                          , new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons("TestString", new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            // Assert
            Assert.AreEqual(0, responseObject.QueueError.Count);
            Assert.AreEqual(false, responseObject.Check);
        }

        [TestMethod]
        public void NotError3()
        {
            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      "", false, "",
                     new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                       "", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }), "TestString", ""), new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons("TestString", new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            // Assert
            Assert.AreEqual(0, responseObject.QueueError.Count);
            Assert.AreEqual(false, responseObject.Check);
        }

        [TestMethod]
        public void ErrorButtons()
        {
            // Arrang
            string excectedText = "Title " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.Buttons.Title";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      "", false, "",
                      new YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList(
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard("TestString"),
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems[]
                      {
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                      },
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { })))
                          , new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons(TestString.Text70, new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            var v = responseObject.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, responseObject.Check);
        }

        [TestMethod]
        public void ErrorItemsCardList()
        {
            // Arrang
            string excectedText1 = "Items должно быть не меньше 1 и не больше 5";
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      "", false, "",
                      new YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList(
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard("TestString"),
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems[]
                      {
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                         new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                              "",
                              new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://www.youtube.com/watch?v=CT_p236O5mI", new { }),
                              "TestString",
                               ""),
                      },
                          new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { })))
                          , new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons("TestString", new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            var v = responseObject.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);

            Assert.AreEqual(true, responseObject.Check);
        }

        [TestMethod]
        public void ErrorBigImageCard()
        {
            // Arrang
            string excectedText1 = "Title " + TestString.TextErrorMes6470;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.BigImageCard.Title";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      "", false, "",
                     new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                       "", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }), TestString.Text70, ""),
                     new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons("TestString", new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            var v = responseObject.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, responseObject.Check);
        }

        [TestMethod]
        public void ErrorText()
        {
            // Arrang
            string excectedText1 = "Text " + TestString.TextErrorMes10241500;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ResponseObject.Text";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                      TestString.Text1500, false, "",
                     new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                       "", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }), "TestString", ""), new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons("TestString", new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            var v = responseObject.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, responseObject.Check);
        }

        [TestMethod]
        public void ErrorTts()
        {
            // Arrang
            string excectedText1 = "Tts " + TestString.TextErrorMes10241500;
            string excectedText2 = "YandexDialogsJsonConverter.Response.ResponseObject.Tts";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ResponseObject responseObject = new YandexDialogsJsonConverter.Response.Сheck.ResponseObject
                (
                  new YandexDialogsJsonConverter.Response.ResponseObject(
                    "", false, TestString.Text1500,
                     new YandexDialogsJsonConverter.Response.ImageCard.BigImageCard(
                       "", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }), "TestString", ""), new YandexDialogsJsonConverter.Response.Buttons[]{
                              new YandexDialogsJsonConverter.Response.Buttons("TestString", new { }, "https://www.youtube.com/watch?v=CT_p236O5mI", true)
                          }));

            var v = responseObject.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);
            Assert.AreEqual(true, responseObject.Check);
        }
    }
}
