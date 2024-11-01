using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KlothesAPI.Migrations
{
    /// <inheritdoc />
    public partial class Correcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Fornecedores",
                newName: "CNPJ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CNPJ",
                table: "Fornecedores",
                newName: "CPF");
        }
    }
}
