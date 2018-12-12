using System.Collections.Generic;
using System.Linq;

namespace TOTVS.PDV.Services.Models
{
    /// <summary>
    /// Classe responsável por tramitar a transação entre o valor pago e que deverá ser recebido
    /// </summary>
    public class Transacao
    {
        public Transacao(float total, float recebido, List<Troco> trocoList)
        {
            Total = total;
            Recebido = recebido;
            TrocoList = trocoList;
        }

        /// <summary>
        /// Lista de objetos da entidade Troco (<see cref="Troco"/>)
        /// </summary>
        /// <example>Lista de Objetos</example>
        public List<Troco> TrocoList { get; }

        /// <summary>
        /// Valor total a ser pago
        /// </summary>
        /// <example>95.2f</example>
        public float Total { get; }

        /// <summary>
        /// Valor efetivamente pago
        /// </summary>
        /// <example>100</example>
        public float Recebido { get; }

        /// <summary>
        /// Valor restante que não pôde ser pago pelo algoritmo de mínima cédula/moeda
        /// </summary>
        /// <example>0.03f</example>
        public float ValorRestante => Total - TrocoList.Sum(s => s.Quantidade * s.Dinheiro.Valor);
    }
}
