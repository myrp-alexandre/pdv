using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TOTVS.PDV.Infra.Data.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dinheiro",
                columns: table => new
                {
                    IdDinheiro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<float>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    UrlImagem = table.Column<string>(maxLength: 250, nullable: false),
                    Descricao = table.Column<string>(maxLength: 80, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinheiro", x => x.IdDinheiro);
                });

            migrationBuilder.CreateTable(
                name: "Transacao",
                columns: table => new
                {
                    IdTransacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Total = table.Column<float>(nullable: false),
                    Recebido = table.Column<float>(nullable: false),
                    ValorRestante = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacao", x => x.IdTransacao);
                });

            migrationBuilder.CreateTable(
                name: "Troco",
                columns: table => new
                {
                    IdTroco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    IdDinheiro = table.Column<int>(nullable: false),
                    IdTransacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troco", x => x.IdTroco);
                    table.ForeignKey(
                        name: "FK_Troco_Dinheiro_IdDinheiro",
                        column: x => x.IdDinheiro,
                        principalTable: "Dinheiro",
                        principalColumn: "IdDinheiro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Troco_Transacao_IdTransacao",
                        column: x => x.IdTransacao,
                        principalTable: "Transacao",
                        principalColumn: "IdTransacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dinheiro",
                columns: new[] { "IdDinheiro", "Ativo", "Descricao", "Quantidade", "Tipo", "UrlImagem", "Valor" },
                values: new object[,]
                {
                    { 1, true, "100 reais", 2147483647, 1, "https://upload.wikimedia.org/wikipedia/pt/d/d2/Nova_familia-100.jpg", 100f },
                    { 2, true, "50 reais", 2147483647, 1, "https://upload.wikimedia.org/wikipedia/pt/7/7c/Nova_familia-50.jpg", 50f },
                    { 3, true, "20 reais", 2147483647, 1, "https://upload.wikimedia.org/wikipedia/pt/2/28/Nova_familia-20.jpg", 20f },
                    { 4, true, "10 reais", 2147483647, 1, "https://upload.wikimedia.org/wikipedia/pt/d/de/Nova_familia-10.jpg", 10f },
                    { 5, true, "50 centavos", 2147483647, 2, "https://upload.wikimedia.org/wikipedia/commons/e/e5/Moeda_de_50_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", 0.5f },
                    { 6, true, "10 centavos", 2147483647, 2, "https://upload.wikimedia.org/wikipedia/commons/3/31/Moeda_de_10_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", 0.1f },
                    { 7, true, "5 centavos", 2147483647, 2, "https://upload.wikimedia.org/wikipedia/commons/5/5f/Moeda_de_5_centavos_da_2%C2%AA_gera%C3%A7%C3%A3o.png", 0.05f },
                    { 8, true, "1 centavo", 2147483647, 2, "https://upload.wikimedia.org/wikipedia/commons/c/ce/Moeda_de_1_centavo_da_2%C2%AA_gera%C3%A7%C3%A3o.jpg", 0.01f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Troco_IdDinheiro",
                table: "Troco",
                column: "IdDinheiro");

            migrationBuilder.CreateIndex(
                name: "IX_Troco_IdTransacao",
                table: "Troco",
                column: "IdTransacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Troco");

            migrationBuilder.DropTable(
                name: "Dinheiro");

            migrationBuilder.DropTable(
                name: "Transacao");
        }
    }
}
