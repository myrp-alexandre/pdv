using System.Collections.Generic;
using System.Runtime.Serialization;
using TOTVS.PDV.Application.Messages.Troco;

namespace TOTVS.PDV.Application.Messages.Transacao
{
    [DataContract]
    public class TransacaoResponse
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

        /// <summary>
        /// Valor restante que não pôde ser pago pelo algoritmo de mínima cédula/moeda
        /// </summary>
        /// <example>0.03f</example>
        [DataMember(Name = "valorRestante")]
        public float ValorRestante { get; set; }

        /// <summary>
        /// Lista de objetos da entidade Troco
        /// </summary>
        /// <example>Lista de Objetos</example>
        [DataMember(Name = "trocoList")]
        public List<TrocoResponse> TrocoList { get; set; }
    }
}
