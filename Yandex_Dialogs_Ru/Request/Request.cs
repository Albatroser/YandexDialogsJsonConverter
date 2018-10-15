using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Request
{
    /// <summary>
    /// Данные, полученные от пользователя.
    /// </summary>
    [DataContract]
    public struct RequestObject
    {
        /// <summary>
        /// Запрос, который был передан вместе с командой активации навыка.
        /// <para>Например, если пользователь активирует навык словами «спроси у Сбербанка где ближайшее отделение», в этом поле будет передана строка «где ближайшее отделение».</para>
        /// <para>Команды активации, с которыми рекомендуется передавать такие запросы:</para>
        /// <para>«скажи», «попроси», «узнай у», «спроси у».</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "command")]
        public string Command { get; set; }

        /// <summary>
        /// Полный текст пользовательского запроса, максимум 1024 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "original_utterance")]
        public string OriginalUtterance { get; set; }

        /// <summary>
        /// Тип ввода, обязательное свойство. Возможные значения:
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "type")]
        public TypeRequestEnum Type { get; set; }

        /// <summary>
        /// Формальные характеристики реплики, которые удалось выделить Яндекс.Диалогам. Отсутствует, если ни одно из вложенных свойств не применимо.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "markup")]
        public Markup Markup { get; set; }

        /// <summary>
        /// JSON, полученный с нажатой кнопкой от обработчика навыка (в ответе на предыдущий запрос), максимум 4096 байт.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "payload")]
        public object PayLoad { get; set; }

        /// <summary>
        /// Слова и именованные сущности, которые Диалоги извлекли из запроса пользователя.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "nlu")]
        public Nlu Nlu { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (RequestObject)obj;
                return
                    this.Command == that.Command &&
                    this.OriginalUtterance == that.OriginalUtterance &&
                    this.Type == that.Type &&
                    this.Markup.Equals(that.Markup) &&
                  //  this.PayLoad == that.PayLoad &&
                    this.Nlu.Equals(that.Nlu);
            }

            return false;
        }
    }
}
