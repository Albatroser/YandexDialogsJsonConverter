using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace YandexDialogsJsonConverter.Request.NamedEntitiesYndex.StructAtom
{
    [DataContract]
    public struct DATETIME 
    {
        /// <summary>
        /// точный год
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "year")]
        public int Year { get; set; }
        /// <summary>
        /// признак того, что в поле year указано относительное количество лет
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "year_is_relative")]
        public bool Year_is_relative { get; set; }

        /// <summary>
        /// месяц
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "month")]
        public int Month { get; set; }
        /// <summary>
        /// признак того, что в поле month указано относительное количество месяцев
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "month_is_relative")]
        public bool Month_is_relative { get; set; }

        /// <summary>
        /// день
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "day")]
        public int Day { get; set; }
        /// <summary>
        /// признак того, что в поле day указано относительное количество дней;
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "day_is_relative")]
        public bool Day_is_relative { get; set; }

        /// <summary>
        /// час
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "hour")]
        public int Hour { get; set; }
        /// <summary>
        /// признак того, что в поле hour указано относительное количество часов;
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "hour_is_relative")]
        public bool Hour_is_relative { get; set; }

        /// <summary>
        /// минута
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "minute")]
        public int Minute { get; set; }
        /// <summary>
        /// признак того, что в поле minute указано относительное количество
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "minute_is_relative")]
        public bool Minute_is_relative { get; set; }


    }
}
