using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.NamedEntitiesYndex.EntitieInf
{
    /// <summary>
    /// Обозначение начала и конца именованной сущности в массиве слов. Нумерация слов в массиве начинается с 0.
    /// </summary>
    [DataContract]
    public struct Tokens
    {
        /// <summary>
        /// Первое слово именованной сущности.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "start")]
        public int Start { get; set; }

        /// <summary>
        /// Первое слово после именованной сущности.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "end")]
        public int End { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (Tokens)obj;
                return
                    this.Start == that.Start &&
                    this.End == that.End;
            }

            return false;
        }
    }
}
