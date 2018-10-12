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
    public class FIO : EntitieInf.Entitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public StructAtom.FIO Value { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as FIO;
                return
                     this.Token.Equals(that.Token) &&
                    this.Value.First_name == that.Value.First_name &&
                    this.Value.Last_name == that.Value.Last_name &&
                    this.Value.Patronymic_name == that.Value.Patronymic_name;
            }

            return false;
        }
    }
}
