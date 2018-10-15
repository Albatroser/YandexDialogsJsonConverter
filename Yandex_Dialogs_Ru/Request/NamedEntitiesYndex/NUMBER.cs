using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using YandexDialogsJsonConverter.Infrastructure;
using YandexDialogsJsonConverter.Request.NamedEntitiesYndex.EntitieInf;

namespace YandexDialogsJsonConverter.Request.NamedEntitiesYndex
{
    [DataContract]
    public struct NUMBER : IEntitie
    {
        /// <summary>
        /// Формальное описание именованной сущности.
        /// </summary>
        [DataMember(Name = "value")]
        public float Value { get; set; }

        /// <summary>
        /// Обозначение начала и конца именованной сущности в массиве слов. Нумерация слов в массиве начинается с 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tokens")]
        public Tokens Token { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (NUMBER)obj;
                return
                   this.Token.Equals(that.Token) &&
                    this.Value == that.Value;
            }

            return false;
        }
    }
}
