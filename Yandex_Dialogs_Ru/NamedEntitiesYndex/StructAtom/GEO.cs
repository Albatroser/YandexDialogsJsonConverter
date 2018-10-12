using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex.StructAtom
{
    [DataContract]
    public struct GEO
    {
        /// <summary>
        /// страна
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "country")]
        public string Country { get; set; }
        /// <summary>
        /// город
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "city")]
        public string City { get; set; }
        /// <summary>
        /// улица
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "street")]
        public string Street { get; set; }
        /// <summary>
        /// номер дома
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "house_number")]
        public string House_number { get; set; }
        /// <summary>
        /// название аэропорта
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "airport")]
        public string Airport { get; set; }
    }
}
