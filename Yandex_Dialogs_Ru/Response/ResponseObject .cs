using System.Runtime.Serialization;
using YandexDialogsJsonConverter.Infrastructure;

namespace YandexDialogsJsonConverter.Response
{
    [DataContract]
    public class ResponseObject : HttpObject
    {
        /// <summary>
        /// Данные для ответа пользователю.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "response ")]
        public Response Response { get; set; }

        /// <summary>
        /// Данные о сессии.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "session")]
        public Session Session { get; set; }
    }
}
