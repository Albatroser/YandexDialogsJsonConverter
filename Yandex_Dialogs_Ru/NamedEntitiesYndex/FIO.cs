using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using YandexDialogsJsonConverter.Infrastructure;
using System.Text;
using YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex
{
    [DataContract]
    public struct FIO : IEntitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public StructAtom.FIO Value { get; set; }

        /// <summary>
        /// Обозначение начала и конца именованной сущности в массиве слов. Нумерация слов в массиве начинается с 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tokens")]
        public Tokens Token { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (FIO)obj;
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
