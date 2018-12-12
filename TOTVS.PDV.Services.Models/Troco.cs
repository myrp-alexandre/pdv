namespace TOTVS.PDV.Services.Models
{
    /// <summary>
    /// Classe responsável pelo gerenciamento do troco
    /// </summary>
    public class Troco
    {
        public Troco(Dinheiro dinheiro, int quantidade)
        {
            Dinheiro = dinheiro;
            Quantidade = quantidade;
        }

        /// <summary>
        /// Objeto da entidade Dinheiro (<see cref="Dinheiro"/>)
        /// </summary>
        /// <example>Objeto</example>
        public Dinheiro Dinheiro { get; }

        /// <summary>
        /// Quantidade de dinheiro para o troco
        /// </summary>
        /// <example>5, 10, 48</example>
        public int Quantidade { get; }
    }
}
