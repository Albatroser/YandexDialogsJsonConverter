﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.ImageCard.CardBase
{
    /// <summary>
    /// Свойства изображения, на которое можно нажать.
    /// </summary>
    [DataContract]
    public struct ButtonCard
    {
        string text, url;
        object payload;
        /// <summary>
        /// Свойства изображения, на которое можно нажать.
        /// </summary>
        /// <param name="TextSet">
        /// Текст, который будет отправлен навыку по нажатию на изображение в качестве команды пользователя.Максимум 64 символа.
        /// <para>Если свойство передано с пустым значением, свойство request.command в запросе будет отправлено пустым.</para>
        /// <para>Если свойство не передано в ответе, Диалоги используют вместо него свойство response.card.title.</para>
        /// </param>
        /// <param name="UrlSet">
        /// URL, который должно открывать нажатие по изображению. Максимум 1024 байта.
        /// </param>
        /// <param name="PayloadSet">
        /// Произвольный JSON, который Яндекс.Диалоги должны отправить обработчику, если пользователь нажмет на изображение.Максимум 4096 байт.
        /// </param>
        public ButtonCard(string TextSet = null, string UrlSet = null, object PayloadSet = null)
        {
            text = TextSet;
            url = UrlSet;
            payload = PayloadSet;
        }

        /// <summary>
        /// Текст, который будет отправлен навыку по нажатию на изображение в качестве команды пользователя.Максимум 64 символа.
        /// <para>Если свойство передано с пустым значением, свойство request.command в запросе будет отправлено пустым.</para>
        /// <para>Если свойство не передано в ответе, Диалоги используют вместо него свойство response.card.title.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "text")]
        public string Text { get { return text; } }

        /// <summary>
        /// URL, который должно открывать нажатие по изображению. Максимум 1024 байта.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "url")]
        public string Url { get { return url; } }

        /// <summary>
        /// Произвольный JSON, который Яндекс.Диалоги должны отправить обработчику, если пользователь нажмет на изображение.Максимум 4096 байт.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "payload")]
        public object Payload { get { return payload; } }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (ButtonCard)obj;
                return
                    this.Text == that.Text &&
                    this.Url == that.Url &&
                    this.Payload == that.Payload;
            }

            return false;
        }

    }
}
