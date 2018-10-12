using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Infrastructure
{
    [DataContract]
    public abstract class HttpObject
    {


        /// <summary>
        /// Версия протокола. Текущая версия — 1.0.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "version")]
        public string version { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as HttpObject;
                return this.version == that.version;
            }

            return false;
        }
    }
}
