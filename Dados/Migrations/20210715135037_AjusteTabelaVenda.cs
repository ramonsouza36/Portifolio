using Microsoft.EntityFrameworkCore.Migrations;

namespace Dados.Migrations
{
    public partial class AjusteTabelaVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "produtoId",
                table: "ItensVendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vendaId",
                table: "ItensVendas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_produtoId",
                table: "ItensVendas",
                column: "produtoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_vendaId",
                table: "ItensVendas",
                column: "vendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVendas_Produtos_produtoId",
                table: "ItensVendas",
                column: "produtoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVendas_Vendas_vendaId",
                table: "ItensVendas",
                column: "vendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Produtos_produtoId",
                table: "ItensVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Vendas_vendaId",
                table: "ItensVendas");

            migrationBuilder.DropIndex(
                name: "IX_ItensVendas_produtoId",
                table: "ItensVendas");

            migrationBuilder.DropIndex(
                name: "IX_ItensVendas_vendaId",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "produtoId",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "vendaId",
                table: "ItensVendas");
        }
    }
}
