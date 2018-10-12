using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using YandexDialogsJsonConverter.Infrastructure;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex
{
    [DataContract]
    public class DATETIME : EntitieInf.Entitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public StructAtom.DATETIME Value { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as DATETIME;
                return
                    this.Token.Equals(that.Token) &&
                    this.Value.Day == that.Value.Day &&
                    this.Value.Day_is_relative == that.Value.Day_is_relative &&
                    this.Value.Hour == that.Value.Hour &&
                    this.Value.Hour_is_relative == that.Value.Hour_is_relative &&
                    this.Value.Minute == that.Value.Minute &&
                    this.Value.Minute_is_relative == that.Value.Minute_is_relative &&
                    this.Value.Month == that.Value.Month &&
                    this.Value.Month_is_relative == that.Value.Month_is_relative &&
                    this.Value.Year == that.Value.Year &&
                    this.Value.Year_is_relative == that.Value.Year_is_relative;
            }

            return false;
        }
    }
}
