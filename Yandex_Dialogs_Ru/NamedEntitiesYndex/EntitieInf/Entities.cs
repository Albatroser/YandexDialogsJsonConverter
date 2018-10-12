using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf
{
    [DataContract]
    public abstract class Entitie
    {
        /// <summary>
        /// Обозначение начала и конца именованной сущности в массиве слов. Нумерация слов в массиве начинается с 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tokens")]
        public Tokens Token { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = obj as Entitie;
                return
                    this.Token == that.Token;
            }
            return false;
        }
    }
}
