using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Request
{
    /// <summary>
    /// Данные о сессии.
    /// </summary>
    [DataContract]
    public class Session
    {
        /// <summary>
        /// Признак новой сессии. Возможные значения:
        ///<para>true — пользователь начал новый разговор с навыком;</para>
        ///<para>false — запрос отправлен в рамках уже начатого разговора.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "new")]
        public bool New { get; set; }

        /// <summary>
        /// Идентификатор вызываемого навыка, присвоенный при создании.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "skill_id")]
        public string SkillId { get; set; }

        /// <summary>
        /// Уникальный идентификатор сессии, максимум 64 символов.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "session_id")]
        public string SessionId { get; set; }

        /// <summary>     
        /// Идентификатор сообщения в рамках сессии, максимум 8 символов.
        /// <para>Инкрементируется с каждым следующим запросом.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "message_id")]
        public int MessageId { get; set; }

        /// <summary>
        /// Идентификатор экземпляра приложения, в котором пользователь общается с Алисой, максимум 64 символа.
        ///<para> Даже если пользователь авторизован с одним и тем же аккаунтом в приложении Яндекс для Android и iOS, Яндекс.Диалоги присвоят отдельный user_id каждому из этих приложений.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "user_id")]
        public string UserId { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as Session;
                return
                    this.New == that.New &&
                    this.MessageId == that.MessageId &&
                    this.SessionId == that.SessionId &&
                    this.UserId == that.UserId &&
                    this.SkillId == that.SkillId;
            }

            return false;
        }
    }
}
