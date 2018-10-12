using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using YandexDialogsJsonConverter.Infrastructure;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex
{
    [DataContract]
    public class GEO : EntitieInf.Entitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public StructAtom.GEO Value { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as GEO;
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

