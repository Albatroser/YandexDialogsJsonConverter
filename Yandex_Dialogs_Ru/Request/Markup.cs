using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace YandexDialogsJsonConverter.Request
{
    /// <summary>
    /// Формальные характеристики реплики, которые удалось выделить Яндекс.Диалогам. Отсутствует, если ни одно из вложенных свойств не применимо.
    /// </summary>
    [DataContract]
    public struct  Markup 
    {
        /// <summary>
        /// Признак реплики, которая содержит криминальный подтекст (самоубийство, разжигание ненависти, угрозы). Вы можете настроить навык на определенную реакцию для таких случаев — например, отвечать «Не понимаю, о чем вы. Пожалуйста, переформулируйте вопрос.»
        ///<para>Возможно только значение true. Если признак не применим, это свойство не включается в ответ.</para>
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "dangerous_context")]
        public bool DangerousContext { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj != null && GetType() == obj.GetType())
            {
                var that = (Markup)obj;
                return
                    this.DangerousContext == that.DangerousContext ;
            }

            return false;
        }
    }
}
