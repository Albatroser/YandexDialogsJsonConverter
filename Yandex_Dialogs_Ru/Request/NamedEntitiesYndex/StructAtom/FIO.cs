using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace YandexDialogsJsonConverter.Request.NamedEntitiesYndex.StructAtom
{
    [DataContract]
    public struct FIO 
    {
        /// <summary>
        /// Имя
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "first_name")]
        public string First_name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "patronymic_name")]
        public string Patronymic_name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "last_name")]
        public string Last_name { get; set; }
           
    }
}
