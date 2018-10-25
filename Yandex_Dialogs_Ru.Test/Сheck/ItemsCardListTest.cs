using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest.Сheck
{
    [TestClass]
    public class ItemsCardListTest
    {
        [TestMethod]
        public void MulltiError()
        {
            // Arrang
            string excectedHeaderCardText1 = "Text " + TestString.TextErrorMes6470;
            string excectedHeaderCardText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard.Text";
            string excectedCardItemsText1 = "Title " + TestString.TextErrorMes6470;
            string excectedCardItemsText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems.Title";
            string excectedCardItemsText3 = "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе";
            string excectedCardItemsText4 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard";
            string excectedFooterCardText1 = "Text " + TestString.TextErrorMes6470;
            string excectedFooterCardText2 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard.Text";
            string excectedFooterCardText3 = "Url - URL который должно открывать нажатие по изображению. Ошибка в адрессе";
            string excectedFooterCardText4 = "YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ItemsCardList itemsCardList = new YandexDialogsJsonConverter.Response.Сheck.ItemsCardList
                (
                  new YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList(
                      new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard(TestString.Text70),
                      new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems[]
                      {
                           new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems(
                               "", 
                               new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "UrlSet", new { }),
                               TestString.Text70, 
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
                       new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard(TestString.Text70, new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "UrlSet", new { }))

                      )
                );

            var v = itemsCardList.QueueError.Dequeue();
            var v1 = itemsCardList.QueueError.Dequeue();
            var v2 = itemsCardList.QueueError.Dequeue();
            var v3 = itemsCardList.QueueError.Dequeue();
            var v4 = itemsCardList.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedHeaderCardText1, v4.ErrorText);
            Assert.AreEqual(excectedHeaderCardText2, v4.OdjName);

            Assert.AreEqual(excectedCardItemsText1, v2.ErrorText);
            Assert.AreEqual(excectedCardItemsText2, v2.OdjName);

            Assert.AreEqual(excectedCardItemsText3, v3.ErrorText);
            Assert.AreEqual(excectedCardItemsText4, v3.OdjName);

            Assert.AreEqual(excectedFooterCardText1, v.ErrorText);
            Assert.AreEqual(excectedFooterCardText2, v.OdjName);

            Assert.AreEqual(excectedFooterCardText3, v1.ErrorText);
            Assert.AreEqual(excectedFooterCardText4, v1.OdjName);

            Assert.AreEqual(true, itemsCardList.Check);
        }

        [TestMethod]
        public void ErrorItems_6()
        {
            // Arrang
            string excectedText1 = "Items должно быть не меньше 1 и не больше 5";
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ItemsCardList itemsCardList = new YandexDialogsJsonConverter.Response.Сheck.ItemsCardList
                (
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
                       new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }))

                      )
                );

            var v = itemsCardList.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);

            Assert.AreEqual(true, itemsCardList.Check);
        }

        [TestMethod]
        public void ErrorItems_0()
        {
            // Arrang
            string excectedText1 = "Items должно быть не меньше 1 и не больше 5";
            string excectedText2 = "YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList";
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ItemsCardList itemsCardList = new YandexDialogsJsonConverter.Response.Сheck.ItemsCardList
                (
                  new YandexDialogsJsonConverter.Response.ImageCard.ItemsCardList(
                      new YandexDialogsJsonConverter.Response.ImageCard.CardBase.HeaderCard("TestString"),
                      new YandexDialogsJsonConverter.Response.ImageCard.CardBase.CardItems[]
                      {

                      },
                       new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }))

                      )
                );

            var v = itemsCardList.QueueError.Dequeue();
            // Assert
            Assert.AreEqual(excectedText1, v.ErrorText);
            Assert.AreEqual(excectedText2, v.OdjName);

            Assert.AreEqual(true, itemsCardList.Check);
        }

        [TestMethod]
        public void NotError()
        {
            // Arrang
            // Act
            YandexDialogsJsonConverter.Response.Сheck.ItemsCardList itemsCardList = new YandexDialogsJsonConverter.Response.Сheck.ItemsCardList
                (
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
                       new YandexDialogsJsonConverter.Response.ImageCard.CardBase.FooterCard("TestString", new YandexDialogsJsonConverter.Response.ImageCard.CardBase.ButtonCard("TextSet", "https://tech.yandex.ru/dialogs/alice/doc/protocol-docpage/#response", new { }))

                      )
                );
            
            // Assert
            Assert.AreEqual(0, itemsCardList.QueueError.Count);
            Assert.AreEqual(false, itemsCardList.Check);
        }
    }
}
