using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Request
{
    [DataContract]
    public class Nlu
    {
        /// <summary>
        /// Слова и именованные сущности, которые Диалоги извлекли из запроса пользователя.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tokens")]
        public string[] Tokens { get; set; }

        /// <summary>
        /// Массив именованных сущностей.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "entities")]
        public NamedEntitiesYndex.EntitieInf.IEntitie[] Entities { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (Nlu)obj;

                bool test = true;

                if (
                    this.Entities == null || 
                    that.Entities == null ||
                    that.Entities.Length != this.Entities.Length) test = false;

                int i = 0;
                while (test && (i < Entities.Length))
                {
                    var aq = this.Entities[i];
                    test = that.Entities.ToList().Exists(p => aq.Equals(p));

                    i++;
                }

                int i2 = 0;
                while (test && (i2 < Entities.Length))
                {
                    var aq = this.Tokens[i2];
                    test = that.Tokens.ToList().Exists(p => p == aq);

                    i2++;
                }


                return test;
            }

            return false;
        }
    }
}
