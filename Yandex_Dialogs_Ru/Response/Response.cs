using System.Runtime.Serialization;
using YandexDialogsJsonConverter.ImageCard.CardBase;
using YandexDialogsJsonConverter.Request;

namespace YandexDialogsJsonConverter.Response
{
    /// <summary>
    /// Данные для ответа пользователю.
    /// </summary>
    [DataContract]
    public class Response
    {
        /// <summary>
        /// Данные для ответа пользователю.
        /// </summary>
        /// <param name="TextSet">Текст, который следует показать и сказать пользователю. Максимум 1024 символа.</param>
        /// <param name="EndSessionSet">Признак конца разговора.
        /// <para>Допустимые значения:</para>
        /// <para>false — сессию следует продолжить;</para>
        /// <para>true — сессию следует завершить.</para></param>
        public Response(string TextSet, bool EndSessionSet = false)
        {
            if (TextSet != null && TextSet != "")
            {
                if (TextSet.Length >= 1024) { Text = TextSet.Remove(1024); }
                else { Text = TextSet; }
            }
            else
            { Text = "Что-то пошло не так."; }
            EndSession = EndSessionSet;
        }
        /// <summary>
        /// Данные для ответа пользователю. При NoControl=true производительность возрастает в 2 раза
        /// </summary>
        /// <param name="TextSet">Текст, который следует показать и сказать пользователю. Максимум 1024 символа.</param>
        /// <param name="EndSessionSet">Признак конца разговора.
        /// <para>Допустимые значения:</para>
        /// <para>false — сессию следует продолжить;</para>
        /// <para>true — сессию следует завершить.</para></param>
        /// <param name="NoControl">Задав данное значение true – отключаем контроль вводимых данных</param>
        public Response(string TextSet, bool EndSessionSet, bool NoControl)
        {
            Text = TextSet;
            EndSession = EndSessionSet;
        }
        /// <summary>
        /// Текст, который следует показать и сказать пользователю. Максимум 1024 символа. Не должен быть пустым.
        ///<para>Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку(свойство response.card). На устройствах, которые поддерживают только голосовое общение с навыком, это будет происходить каждый раз, когда навык присылает карточку в ответе.</para> 
        ///<para>  В тексте ответа можно указать переводы строк последовательностью «\n», например: "Отдых напрасен. Дорога крута.\nВечер прекрасен. Стучу в ворота."</para> 
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Ответ в формате TTS (text-to-speech), максимум 1024 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tts")]
        public string Tts { get; set; }

        /// <summary>
        /// Описание карточки — сообщения с поддержкой изображений.
        /// <para>Если приложению удается отобразить карточку для пользователя, свойство response.text не используется.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "card")]
        public ICard Card { get; set; }

        /// <summary>
        /// Кнопки, которые следует показать пользователю.
        /// <para> Все указанные кнопки выводятся после основного ответа Алисы, описанного в свойствах response.text и response.card.Кнопки можно использовать как релевантные ответу ссылки или подсказки для продолжения разговора. </para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "buttons")]
        public Buttons[] Buttons { get; set; }

        /// <summary>
        /// Признак конца разговора.
        /// <para>Допустимые значения:</para>
        /// <para>false — сессию следует продолжить;</para>
        /// <para>true — сессию следует завершить.</para>
        /// <para></para>
        /// </summary>
        [DataMember(Name = "end_session")]
        public bool EndSession { get; set; }
    }
}
