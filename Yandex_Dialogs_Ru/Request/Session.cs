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
    public class Session : Response.Session
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
