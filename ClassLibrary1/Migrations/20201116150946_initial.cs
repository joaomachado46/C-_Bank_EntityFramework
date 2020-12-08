using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoDeContas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeConta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDeContas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitularContas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitularContas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cartoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCartao = table.Column<int>(type: "int", nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saldo = table.Column<double>(type: "float", nullable: false),
                    IdTipoDeConta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cartoes_TipoDeContas_IdTipoDeConta",
                        column: x => x.IdTipoDeConta,
                        principalTable: "TipoDeContas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartaoTitular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCartao = table.Column<int>(type: "int", nullable: false),
                    IdTitular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartaoTitular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartaoTitular_Cartoes_IdCartao",
                        column: x => x.IdCartao,
                        principalTable: "Cartoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartaoTitular_TitularContas_IdTitular",
                        column: x => x.IdTitular,
                        principalTable: "TitularContas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEmprestimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mensalidade = table.Column<int>(type: "int", nullable: false),
                    NumeroContrato = table.Column<int>(type: "int", nullable: false),
                    IdCartao = table.Column<int>(type: "int", nullable: true),
                    IdTitularConta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Cartoes_IdCartao",
                        column: x => x.IdCartao,
                        principalTable: "Cartoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emprestimos_TitularContas_IdTitularConta",
                        column: x => x.IdTitularConta,
                        principalTable: "TitularContas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Levantamento = table.Column<int>(type: "int", nullable: false),
                    Deposito = table.Column<int>(type: "int", nullable: false),
                    ValorSaldo = table.Column<double>(type: "float", nullable: false),
                    NovoSaldo = table.Column<double>(type: "float", nullable: false),
                    CartaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentos_Cartoes_CartaoId",
                        column: x => x.CartaoId,
                        principalTable: "Cartoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartaoTitular_IdCartao",
                table: "CartaoTitular",
                column: "IdCartao");

            migrationBuilder.CreateIndex(
                name: "IX_CartaoTitular_IdTitular",
                table: "CartaoTitular",
                column: "IdTitular");

            migrationBuilder.CreateIndex(
                name: "IX_Cartoes_IdTipoDeConta",
                table: "Cartoes",
                column: "IdTipoDeConta");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_IdCartao",
                table: "Emprestimos",
                column: "IdCartao");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_IdTitularConta",
                table: "Emprestimos",
                column: "IdTitularConta");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentos_CartaoId",
                table: "Movimentos",
                column: "CartaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartaoTitular");

            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Movimentos");

            migrationBuilder.DropTable(
                name: "TitularContas");

            migrationBuilder.DropTable(
                name: "Cartoes");

            migrationBuilder.DropTable(
                name: "TipoDeContas");
        }
    }
}
