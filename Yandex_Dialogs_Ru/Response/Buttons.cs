using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response
{
    [DataContract]
    public class Buttons
    {
        /// <summary>
        /// Текст кнопки, обязателен для каждой кнопки. Максимум 64 символа.
        /// <para> Если для кнопки не указано свойство url, по нажатию текст кнопки будет отправлен навыку как реплика пользователя.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Произвольный JSON, который Яндекс.Диалоги должны отправить обработчику, если пользователь нажмет на изображение.Максимум 4096 байт.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "payload")]
        public object Payload { get; set; }

        /// <summary>
        /// URL, который должно открывать нажатие по изображению. Максимум 1024 байта.
        /// <para>Если свойство url не указано, по нажатию кнопки навыку будет отправлен текст кнопки.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Признак того, что кнопку нужно убрать после следующей реплики пользователя.Допустимые значения:
        /// <para>false — кнопка должна оставаться активной (значение по умолчанию);</para>
        /// <para>true — кнопку нужно скрывать после нажатия.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "hide")]
        public bool Hide { get; set; }
        

    }
}
