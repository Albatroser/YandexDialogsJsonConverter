using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Infrastructure
{
    /// <summary>
    /// Информация об устройстве, с помощью которого пользователь разговаривает с Алисой.
    /// </summary>
    [DataContract]
    public struct Meta
    {
        /// <summary>
        /// Язык в POSIX-формате, максимум 64 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Название часового пояса, включая алиасы, максимум 64 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Идентификатор устройства и приложения, в котором идет разговор, максимум 1024 символа.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "client_id")]
        public string Client_id { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (Meta)obj ;
                return 
                    this.Locale == that.Locale && 
                    this.Timezone == that.Timezone && 
                    this.Client_id == that.Client_id;
            }

            return false;
        }
    }
}
