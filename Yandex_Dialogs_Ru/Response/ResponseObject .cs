using System.Runtime.Serialization;
using YandexDialogsJsonConverter.Infrastructure;

namespace YandexDialogsJsonConverter.Response
{
    [DataContract]
    public struct ResponseObject : IHttpObject
    {
        Response response;
        Session session;
        string version;
        public ResponseObject(Response ResponseSet, Session SessionSet, string VersionSet = "1.0")
        {
            response = ResponseSet;
            session = SessionSet;
            version = VersionSet;
        }

        /// <summary>
        /// Данные для ответа пользователю.
        /// </summary>
        [DataMember(Name = "response ")]
        public Response Response { get { return response; } }

        /// <summary>
        /// Данные о сессии.
        /// </summary>
        [DataMember( Name = "session")]
        public Session Session { get { return session; } }


        /// <summary>
        /// Версия протокола. Текущая версия — 1.0.
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get { return version; } set { version = value; } }
    }
}
