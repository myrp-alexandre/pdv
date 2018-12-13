namespace TOTVS.PDV.Services.Models
{
    /// <summary>
    /// Classe responsável pelo gerenciamento do troco
    /// </summary>
    public class Troco
    {
        #region Construtores
        private Troco() { }

        public Troco(Dinheiro dinheiro, int quantidade)
        {
            Dinheiro = dinheiro;
            Quantidade = quantidade;
            IdDinheiro = Dinheiro.IdDinheiro;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Chave primária
        /// </summary>
        /// <example>Inteiro superior a zero</example>
        public int IdTroco { get; private set; } = 0;

        /// <summary>
        /// Quantidade de dinheiro para o troco
        /// </summary>
        /// <example>5, 10, 48</example>
        public int Quantidade { get; private set; }
        #endregion

        #region Relacionamentos
        /// <summary>
        /// Objeto da entidade Dinheiro (<see cref="Dinheiro"/>)
        /// </summary>
        /// <example>Objeto</example>
        public Dinheiro Dinheiro { get; private set; }

        /// <summary>
        /// Chave estrangeira
        /// </summary>
        /// <example>Inteiro superior a zero</example>
        public int IdDinheiro { get; private set; }

        /// <summary>
        /// Objeto da entidade Dinheiro (<see cref="Transacao"/>)
        /// </summary>
        /// <example>Objeto</example>
        public Transacao Transacao { get; private set; }

        /// <summary>
        /// Chave estrangeira
        /// </summary>
        /// <example>Inteiro superior a zero</example>
        public int IdTransacao { get; private set; }
        #endregion 
    }
}
