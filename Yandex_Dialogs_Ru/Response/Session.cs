using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response
{
    /// <summary>
    /// Данные о сессии.
    /// </summary>
    [DataContract]
    public struct Session
    {
        private string sessionId;
        private string userId;
        private int messageId;
        public Session(string sessionIdset, int messageIdset, string userIdset)
        {
            sessionId = sessionIdset;
            messageId = messageIdset;
            userId = userIdset;
        }

        /// <summary>
        /// Уникальный идентификатор сессии, максимум 64 символов.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "session_id")]
        public string SessionId { get { return sessionId; } }

        /// <summary>     
        /// Идентификатор сообщения в рамках сессии, максимум 8 символов.
        /// <para>Инкрементируется с каждым следующим запросом.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "message_id")]
        public int MessageId { get { return messageId; } }

        /// <summary>
        /// Идентификатор экземпляра приложения, в котором пользователь общается с Алисой, максимум 64 символа.
        ///<para> Даже если пользователь авторизован с одним и тем же аккаунтом в приложении Яндекс для Android и iOS, Яндекс.Диалоги присвоят отдельный user_id каждому из этих приложений.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "user_id")]
        public string UserId { get { return userId; } }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (Session)obj;
                return
                    this.MessageId == that.MessageId &&
                    this.SessionId == that.SessionId &&
                    this.UserId == that.UserId;
            }

            return false;
        }
    }
}
