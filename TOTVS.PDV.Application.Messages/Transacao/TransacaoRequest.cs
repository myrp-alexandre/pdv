using System.Runtime.Serialization;

namespace TOTVS.PDV.Application.Messages.Transacao
{
    [DataContract]
    public class TransacaoRequest
    {
        /// <summary>
        /// Valor total a ser pago
        /// </summary>
        /// <example>95.2f</example>
        [DataMember(Name = "total")]
        public float Total { get; set; }

        /// <summary>
        /// Valor efetivamente pago
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "recebido")]
        public float Recebido { get; set; }
    }
}
