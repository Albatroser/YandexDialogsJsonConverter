using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using YandexDialogsJsonConverter.Infrastructure;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex
{
    [DataContract]
    public class NUMBER : EntitieInf.Entitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public float Value { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as NUMBER;
                return
                   this.Token.Equals(that.Token) &&
                    this.Value == that.Value;
            }

            return false;
        }
    }
}
