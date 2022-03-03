using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteMarttech.Migrations
{
    public partial class CliEnderecoIDRM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_EnderecosId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_EnderecosId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CliEnderecoId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EnderecosId",
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
                name: "CliEnderecoId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnderecosId",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecosId",
                table: "Cliente",
                column: "EnderecosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_EnderecosId",
                table: "Cliente",
                column: "EnderecosId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
