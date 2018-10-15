using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Infrastructure
{
    public interface IHttpObject
    {
        /// <summary>
        /// Версия протокола. Текущая версия — 1.0.
        /// </summary>
         string Version { get; set; }       
    }
}
