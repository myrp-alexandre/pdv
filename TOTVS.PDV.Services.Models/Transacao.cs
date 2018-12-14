using System.Collections.Generic;
using System.Linq;

namespace TOTVS.PDV.Services.Models
{
    /// <summary>
    /// Classe responsável por tramitar a transação entre o valor pago e que deverá ser recebido
    /// </summary>
    public class Transacao
    {
        #region Construtores
        private Transacao() { }

        public Transacao(float total, float recebido, List<Troco> trocoList)
        {
            Total = total;
            Recebido = recebido;
            TrocoList = trocoList;
            ValorRestante = Recebido - Total - TrocoList.Sum(s => s.Quantidade * s.Dinheiro.Valor);
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Chave primária
        /// </summary>
        /// <example>Inteiro superior a zero</example>
        public int IdTransacao { get; private set; } = 0;

        /// <summary>
        /// Valor total a ser pago
        /// </summary>
        /// <example>95.2f</example>
        public float Total { get; private set; }

        /// <summary>
        /// Valor efetivamente pago
        /// </summary>
        /// <example>100</example>
        public float Recebido { get; private set; }

        /// <summary>
        /// Valor restante que não pôde ser pago pelo algoritmo de mínima cédula/moeda
        /// </summary>
        /// <example>0.03f</example>
        public float ValorRestante { get; private set; }
        #endregion

        #region Relacionamento
        /// <summary>
        /// Lista de objetos da entidade Troco (<see cref="Troco"/>)
        /// </summary>
        /// <example>Lista de Objetos</example>
        public List<Troco> TrocoList { get; private set; }
        #endregion
    }
}
