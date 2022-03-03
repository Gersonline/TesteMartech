using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteMarttech.Migrations
{
    public partial class ClienteEnderecos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_ClienteId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Endereco",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClientesId",
                table: "Endereco",
                column: "ClientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_ClientesId",
                table: "Endereco",
                column: "ClientesId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_ClientesId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_ClientesId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "ClientesId",
                table: "Endereco");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Endereco",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClienteId",
                table: "Endereco",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
