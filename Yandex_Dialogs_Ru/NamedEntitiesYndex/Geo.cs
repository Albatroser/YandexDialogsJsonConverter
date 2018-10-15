using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using YandexDialogsJsonConverter.Infrastructure;
using YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex
{
    [DataContract]
    public struct GEO : IEntitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public StructAtom.GEO Value { get; set; }

        /// <summary>
        /// Обозначение начала и конца именованной сущности в массиве слов. Нумерация слов в массиве начинается с 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tokens")]
        public Tokens Token { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (GEO)obj;
                return
                    this.Token.Equals(that.Token) &&
                    this.Value.Airport == that.Value.Airport &&
                    this.Value.City == that.Value.City &&
                    this.Value.Country == that.Value.Country &&
                    this.Value.House_number == that.Value.House_number &&
                    this.Value.Street == that.Value.Street;
            }

            return false;
        }
    }
}

