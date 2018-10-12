using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using YandexDialogsJsonConverter.Infrastructure;

namespace YandexDialogsJsonConverter.Request
{
    [DataContract]
    public class Request : HttpObject
    {
        /// <summary>
        /// Информация об устройстве, с помощью которого пользователь разговаривает с Алисой.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Данные, полученные от пользователя.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "request")]
        public RequestObject RequestObject { get; set; }

        /// <summary>
        /// Данные о сессии.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "session")]
        public Session Session { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as Request;
                return
                    this.Session.Equals(that.Session) &&
                    this.version == that.version &&
                    this.Meta.Equals(that.Meta) &&
                    this.RequestObject.Equals(that.RequestObject);
            }

            return false;
        }
    }
}
