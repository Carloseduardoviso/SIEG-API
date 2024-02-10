using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adaptadores.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SIEG");

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "SIEG",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente = table.Column<string>(type: "archar(250)", maxLength: 200, nullable: true),
                    endereco = table.Column<string>(type: "archar(250)", maxLength: 150, nullable: true),
                    bairro = table.Column<string>(type: "archar(250)", maxLength: 100, nullable: true),
                    cidade = table.Column<string>(type: "archar(250)", maxLength: 100, nullable: true),
                    uf = table.Column<string>(type: "archar(250)", maxLength: 2, nullable: true),
                    cep = table.Column<string>(type: "archar(250)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "archar(250)", maxLength: 200, nullable: false),
                    celular = table.Column<string>(type: "archar(250)", maxLength: 20, nullable: true),
                    ativo_cliente = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "ControleEstoques",
                schema: "SIEG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    column1 = table.Column<string>(type: "archar(250)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControleEstoques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntradaDoProdutos",
                schema: "SIEG",
                columns: table => new
                {
                    id_entrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_produto = table.Column<int>(type: "int", nullable: false),
                    data_entrada = table.Column<DateTime>(type: "date", nullable: false),
                    qtde_entrada = table.Column<int>(type: "int", nullable: false),
                    motivo_entrada = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 120, nullable: false),
                    hora_entrada = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaDoProdutos", x => x.id_entrada);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                schema: "SIEG",
                columns: table => new
                {
                    id_fornecedo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fornecedo = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 200, nullable: true),
                    endereco = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 150, nullable: true),
                    bairro = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 100, nullable: true),
                    cidade = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 100, nullable: true),
                    uf = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 2, nullable: true),
                    cep = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 200, nullable: false),
                    celular = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 20, nullable: true),
                    ativo_fornecedo = table.Column<int>(type: "int", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.id_fornecedo);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                schema: "SIEG",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_venda = table.Column<int>(type: "int", nullable: false),
                    id_produto = table.Column<int>(type: "int", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    qtde = table.Column<int>(type: "int", nullable: false),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.id_item);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                schema: "SIEG",
                columns: table => new
                {
                    id_movimentacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_produto = table.Column<int>(type: "int", nullable: false),
                    id_entrada_saida = table.Column<int>(type: "int", nullable: false),
                    tipo_movimentacao = table.Column<int>(type: "int", nullable: false),
                    qtde = table.Column<int>(type: "int", nullable: false),
                    motivo = table.Column<int>(type: "int", nullable: false),
                    data_movimentacao = table.Column<int>(type: "int", nullable: false),
                    hora_movimentacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.id_movimentacao);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                schema: "SIEG",
                columns: table => new
                {
                    id_produto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "archar(250)", nullable: true),
                    estoque_inicial = table.Column<int>(type: "int", nullable: false),
                    estoque_minimo = table.Column<int>(type: "int", nullable: false),
                    estoque_atual = table.Column<int>(type: "int", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id_produto);
                });

            migrationBuilder.CreateTable(
                name: "SaidaDeProdutos",
                schema: "SIEG",
                columns: table => new
                {
                    id_saida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_produto = table.Column<int>(type: "int", nullable: false),
                    data_saida = table.Column<DateTime>(type: "date", nullable: false),
                    qtde_saida = table.Column<int>(type: "int", nullable: false),
                    motivo_saida = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 120, nullable: false),
                    hora_saida = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaidaDeProdutos", x => x.id_saida);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "SIEG",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 50, nullable: false),
                    ativo_usuario = table.Column<string>(type: "archar(250)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "VendaDeProdutos",
                schema: "SIEG",
                columns: table => new
                {
                    id_venda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    data_venda = table.Column<DateTime>(type: "date", nullable: false),
                    hora_venda = table.Column<TimeSpan>(type: "time", nullable: false),
                    total_venda = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaDeProdutos", x => x.id_venda);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "ControleEstoques",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "EntradaDoProdutos",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "Fornecedores",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "Itens",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "Movimentacoes",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "Produtos",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "SaidaDeProdutos",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "SIEG");

            migrationBuilder.DropTable(
                name: "VendaDeProdutos",
                schema: "SIEG");
        }
    }
}
