using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Request.NamedEntitiesYndex.EntitieInf
{
    //[DataContract]
    public interface IEntitie
    {
        /// <summary>
        /// Обозначение начала и конца именованной сущности в массиве слов. Нумерация слов в массиве начинается с 0.
        /// </summary>
       // [DataMember(EmitDefaultValue = false, Name = "tokens")]
         Tokens Token { get; set; }      
    }
}
