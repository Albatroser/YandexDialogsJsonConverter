using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YandexDialogsJsonConverterTest
{
    [TestClass]
    public class ApiTests
    {
        string valueGetRequest = "{\"meta\": {\"locale\": \"ru-RU\", \"timezone\": \"Europe/Moscow\", \"client_id\": \"ru.yandex.searchplugin/5.80 (Samsung Galaxy; Android 4.4)\" },\"request\": { \"command\": \"закажи пиццу на улицу льва толстого, 16 на завтра\", \"original_utterance\": \"закажи пиццу на улицу льва толстого, 16 на завтра\", \"type\": \"SimpleUtterance\", \"markup\": { \"dangerous_context\": true }, \"payload\": {}, \"nlu\": { \"tokens\": [ \"закажи\", \"пиццу\", \"на\", \"льва\", \"толстого\", \"16\", \"на\", \"завтра\" ], \"entities\": [ { \"tokens\": { \"start\": 2, \"end\": 6 }, \"type\": \"YANDEX.GEO\", \"value\": { \"house_number\": \"16\", \"street\": \"льва толстого\" } }, { \"tokens\": { \"start\": 3, \"end\": 5 }, \"type\": \"YANDEX.FIO\", \"value\": { \"first_name\": \"лев\", \"last_name\": \"толстой\" } }, { \"tokens\": { \"start\": 5, \"end\": 6 }, \"type\": \"YANDEX.NUMBER\", \"value\": 16 }, { \"tokens\": { \"start\": 6, \"end\": 8 }, \"type\": \"YANDEX.DATETIME\", \"value\": { \"day\": 1, \"day_is_relative\": true } } ] } }, \"session\": { \"new\": true, \"message_id\": 4, \"session_id\": \"2eac4854-fce721f3-b845abba-20d60\", \"skill_id\": \"3ad36498-f5rd-4079-a14b-788652932056\",    \"user_id\": \"AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC\" }, \"version\": \"1.0\"}";
        YandexDialogsJsonConverter.Request.Request requestExpected = new YandexDialogsJsonConverter.Request.Request
        {
            Meta = new YandexDialogsJsonConverter.Infrastructure.Meta
            {
                Locale = "ru-RU",
                Client_id = "ru.yandex.searchplugin/5.80 (Samsung Galaxy; Android 4.4)",
                Timezone = "Europe/Moscow"
            },
            Session = new YandexDialogsJsonConverter.Request.Session
            {
                SessionId = "2eac4854-fce721f3-b845abba-20d60",
                MessageId = 4,
                New = true,
                SkillId = "3ad36498-f5rd-4079-a14b-788652932056",
                UserId = "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC"
            },
            Version = "1.0",
            RequestObject = new YandexDialogsJsonConverter.Request.RequestObject
            {
                Command = "закажи пиццу на улицу льва толстого, 16 на завтра",
                OriginalUtterance = "закажи пиццу на улицу льва толстого, 16 на завтра",
                Type = YandexDialogsJsonConverter.Request.TypeRequestEnum.SimpleUtterance,
                Markup = new YandexDialogsJsonConverter.Request.Markup { DangerousContext = true },
                PayLoad = null
,
                Nlu = new YandexDialogsJsonConverter.Request.Nlu
                {
                    Tokens = new string[]
                    {
                        "закажи",
                        "пиццу",
                        "на",
                        "льва",
                        "толстого",
                        "16",
                        "на",
                        "завтра",
                    },
                    Entities = new YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf.IEntitie[]
                    {
                        new YandexDialogsJsonConverter.NamedEntitiesYndex.GEO
                        {
                            Token = new YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf.Tokens
                            {
                                End =6,
                                Start =2
                            },
                            Value = new YandexDialogsJsonConverter.NamedEntitiesYndex.StructAtom.GEO{
                                House_number ="16",
                                Street = "льва толстого"
                            }
                        },
                        new YandexDialogsJsonConverter.NamedEntitiesYndex.FIO
                        {
                            Token = new YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf.Tokens
                            {
                                End =5,
                                Start =3
                            },
                            Value = new YandexDialogsJsonConverter.NamedEntitiesYndex.StructAtom.FIO
                            {
                                First_name = "лев",
                                Last_name = "толстой"
                            }

                        },
                        new YandexDialogsJsonConverter.NamedEntitiesYndex.NUMBER
                        {
                            Token = new YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf.Tokens
                            {
                                End =6,
                                Start =5
                            },
                            Value = 16
                        },
                        new YandexDialogsJsonConverter.NamedEntitiesYndex.DATETIME
                        {
                            Token = new YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf.Tokens
                            {
                                End =8,
                                Start =6
                            },
                            Value = new YandexDialogsJsonConverter.NamedEntitiesYndex.StructAtom.DATETIME
                            {
                                Day=1,
                                Day_is_relative = true
                            }

                        },
                    }
                }
            }

        };


        [TestMethod]
        public void GetRequest_string()
        {
            // Arrang
            YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
            // Act
            YandexDialogsJsonConverter.Request.Request requestObject = api.GetRequest(valueGetRequest);
            // Assert
            Assert.AreEqual(requestExpected, requestObject);
        }


        [TestMethod]
        public void GetRequest_string2()
        {
            // Arrang
            YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
            // Act
            YandexDialogsJsonConverter.Request.Request requestObject = api.GetRequest(valueGetRequest);
            for (int i = 0; i < 100; i++)
            { requestObject = api.GetRequest(valueGetRequest); }
            // Assert
            Assert.AreEqual(requestExpected, requestObject);

        }

        [TestMethod]
        public void SetResponse_string_1()
        {
            // Arrang
            YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
            string jsonExpected = "{\"response\": {\"text\": \"Здравствуйте! Это мы, хороводоведы.\",\"tts\": \"Здравствуйте! Это мы, хоров+одо в+еды.\", \"buttons\": [ { \"title\": \"Надпись на кнопке\", \"payload\": {}, \"url\": \"https://example.com/\", \"hide\": true } ], \"end_session\": false  }, \"session\": { \"session_id\": \"2eac4854-fce721f3-b845abba-20d60\", \"message_id\": 4, \"user_id\": \"AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC\"  },  \"version\": \"1.0\"}";

            YandexDialogsJsonConverter.Response.ResponseObject value = new YandexDialogsJsonConverter.Response.ResponseObject(
                new YandexDialogsJsonConverter.Response.Response("Здравствуйте! Это мы, хороводоведы.",
                "Здравствуйте! Это мы, хоров+одо в+еды.", null, new YandexDialogsJsonConverter.Response.Buttons[]{
                        new YandexDialogsJsonConverter.Response.Buttons ( "Надпись на кнопке", new object(),"https://example.com/", true)
                }),
                new YandexDialogsJsonConverter.Response.Session
                ("2eac4854-fce721f3-b845abba-20d60", 4, "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC")
            );

            // Act
            string json = api.SetResponse(value);
            string json1 = json.Replace(" ", "");
            string jsonExpected1 = jsonExpected.Replace(" ", "");
            bool s = json1 == jsonExpected1;
            // Assert
            Assert.AreEqual(jsonExpected1, json1, true);
        }

        [TestMethod]
        public void SetResponse_string_2()
        {
            // Arrang
            YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
            string jsonExpected = " { \"response\": { \"text\": \"Здравствуйте! Это мы, хороводоведы.\", \"tts\": \"Здравствуйте! Это мы, хоров+одо в+еды.\", \"card\": { \"type\": \"BigImage\", \"image_id\": \"1027858/46r960da47f60207e924\", \"title\": \"Заголовок для изображения\", \"description\": \"Описание изображения.\", \"button\": { \"text\": \"Надпись на кнопке\", \"url\": \"http://example.com/\", \"payload\": { } } }, \"buttons\": [ { \"title\": \"Надпись на кнопке\", \"payload\": {}, \"url\": \"https://example.com/\", \"hide\": true } ], \"end_session\": false  },  \"session\": { \"session_id\": \"2eac4854 - fce721f3 - b845abba - 20d60\", \"message_id\": 4, \"user_id\": \"AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC\" }, \"version\": \"1.0\"}";

            YandexDialogsJsonConverter.Response.ResponseObject value = new YandexDialogsJsonConverter.Response.ResponseObject(
                new YandexDialogsJsonConverter.Response.Response("Здравствуйте! Это мы, хороводоведы.",
                "Здравствуйте! Это мы, хоров+одо в+еды.",
                new YandexDialogsJsonConverter.ImageCard.BigImageCard
                {
                    Image_id = "1027858/46r960da47f60207e924",
                    Title = "Заголовок для изображения",
                    Description = "Описание изображения.",
                    Button = new YandexDialogsJsonConverter.ImageCard.CardBase.ButtonCard
                    {
                        Text = "Надпись на кнопке",
                        Url = "http://example.com/",
                        Payload = new object()
                    }
                },
                new YandexDialogsJsonConverter.Response.Buttons[]{
                        new YandexDialogsJsonConverter.Response.Buttons
                       ( "Надпись на кнопке", new object(), "https://example.com/", true)
                    }),
                new YandexDialogsJsonConverter.Response.Session
                ("2eac4854-fce721f3-b845abba-20d60", 4, "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC")
                );

            // Act
            string json = api.SetResponse(value);
            string json1 = json.Replace(" ", "");
            string jsonExpected1 = jsonExpected.Replace(" ", "");
            bool s = json1 == jsonExpected1;
            // Assert
            Assert.AreEqual(jsonExpected1, json1, true);
        }

        [TestMethod]
        public void SetResponse_string_3()
        {
            // Arrang
            YandexDialogsJsonConverter.Api api = new YandexDialogsJsonConverter.Api();
            string jsonExpected = "{ \"response\": { \"text\": \"Здравствуйте! Это мы, хороводоведы.\", \"tts\": \"Здравствуйте! Это мы, хоров+одо в+еды.\", \"card\": { \"type\": \"ItemsList\", \"header\": { \"text\": \"Заголовок галереи изображений\" }, \"items\": [ { \"image_id\": \"<image_id>\", \"title\": \"Заголовок для изображения\", \"description\": \"Описание изображения.\", \"button\": {\"text\": \"Надпись на кнопке\", \"url\": \"http://example.com/\", \"payload\": {}} } ], \"footer\": { \"text\": \"Текст блока под изображением.\", \"button\": { \"text\": \"Надпись на кнопке\", \"url\": \"https://example.com/\", \"payload\": {} } } }, \"buttons\": [ { \"title\": \"Надпись на кнопке\", \"payload\": {}, \"url\": \"https://example.com/\", \"hide\": true } ], \"end_session\": false  },  \"session\": { \"session_id\": \"2eac4854-fce721f3-b845abba-20d60\", \"message_id\": 4, \"user_id\": \"AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC\" }, \"version\": \"1.0\"}";



            YandexDialogsJsonConverter.Response.ResponseObject value = new YandexDialogsJsonConverter.Response.ResponseObject(
                new YandexDialogsJsonConverter.Response.Response("Здравствуйте! Это мы, хороводоведы.",

                     "Здравствуйте! Это мы, хоров+одо в+еды.",
                     new YandexDialogsJsonConverter.ImageCard.ItemsCardList
                     {
                         Header = new YandexDialogsJsonConverter.ImageCard.CardBase.HeaderCard
                         {
                             Text = "Заголовок галереи изображений"
                         },
                         Items = new YandexDialogsJsonConverter.ImageCard.CardBase.CardItems[]
                        {
                            new YandexDialogsJsonConverter.ImageCard.CardBase.CardItems{
                                Image_id = "<image_id>",
                                Title = "Заголовок для изображения",
                                Description = "Описание изображения.",
                                Button = new YandexDialogsJsonConverter.ImageCard.CardBase.ButtonCard
                                {
                                    Text = "Надпись на кнопке",
                                    Url = "http://example.com/",
                                    Payload = new object()
                                }
                            }
                        },
                         Footer = new YandexDialogsJsonConverter.ImageCard.CardBase.FooterCard
                         {
                             Text = "Текстблокаподизображением.",
                             Button = new YandexDialogsJsonConverter.ImageCard.CardBase.ButtonCard
                             {
                                 Text = "Надпись на кнопке",
                                 Url = "https://example.com/",
                                 Payload = new object()
                             }
                         }
                     },
                     new YandexDialogsJsonConverter.Response.Buttons[]{
                        new YandexDialogsJsonConverter.Response.Buttons ( "Надпись на кнопке", new object(), "https://example.com/", true) }
                    )
               ,
                new YandexDialogsJsonConverter.Response.Session
                ("2eac4854-fce721f3-b845abba-20d60", 4, "AC9WC3DF6FCE052E45A4566A48E6B7193774B84814CE49A922E163B8B29881DC")
            );

            // Act
            string json = api.SetResponse(value);
            string json1 = json.Replace(" ", "");
            string jsonExpected1 = jsonExpected.Replace(" ", "");
            bool s = json1 == jsonExpected1;
            // Assert
            Assert.AreEqual(jsonExpected1, json1, true);
        }
    }
}
