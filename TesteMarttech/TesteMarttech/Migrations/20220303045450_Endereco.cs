using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteMarttech.Migrations
{
    public partial class Endereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "EnderecoId",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Cliente");

            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Endereco",
                type: "int",
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
    }
}
