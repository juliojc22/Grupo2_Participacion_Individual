using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grupo2.Migrations
{
    /// <inheritdoc />
    public partial class AgregarFacultad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultadId",
                table: "Carrera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Facultad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultad", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrera_FacultadId",
                table: "Carrera",
                column: "FacultadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera",
                column: "FacultadId",
                principalTable: "Facultad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrera_Facultad_FacultadId",
                table: "Carrera");

            migrationBuilder.DropTable(
                name: "Facultad");

            migrationBuilder.DropIndex(
                name: "IX_Carrera_FacultadId",
                table: "Carrera");

            migrationBuilder.DropColumn(
                name: "FacultadId",
                table: "Carrera");
        }
    }
}
