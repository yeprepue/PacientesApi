using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PacientesApi.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablasCitasMedicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_pacientes",
                table: "pacientes");

            migrationBuilder.RenameTable(
                name: "pacientes",
                newName: "Pacientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "pacientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pacientes",
                table: "pacientes",
                column: "Id");
        }
    }
}
