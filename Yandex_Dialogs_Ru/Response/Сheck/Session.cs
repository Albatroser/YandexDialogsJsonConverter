using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Response.Сheck
{
    public class Session : ErrorChecking
    {
        YandexDialogsJsonConverter.Response.Session session;

        public Session(YandexDialogsJsonConverter.Response.Session sessionSet)
        {
            session = sessionSet;
            StringCheckNotNullLimitLength("MessageId", session, session.MessageId.ToString(),  8);
            StringCheckNotNullLimitLength("SessionId", session, 64);
            StringCheckNotNullLimitLength("UserId", session, 64);

        }   
     }
}
