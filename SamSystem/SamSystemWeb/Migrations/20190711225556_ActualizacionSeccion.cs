using Microsoft.EntityFrameworkCore.Migrations;

namespace SamSystemWeb.Migrations
{
    public partial class ActualizacionSeccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdid",
                table: "Estudiantes");

            migrationBuilder.AlterColumn<short>(
                name: "SeccionIdid",
                table: "Estudiantes",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdid",
                table: "Estudiantes",
                column: "SeccionIdid",
                principalTable: "Secciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdid",
                table: "Estudiantes");

            migrationBuilder.AlterColumn<short>(
                name: "SeccionIdid",
                table: "Estudiantes",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdid",
                table: "Estudiantes",
                column: "SeccionIdid",
                principalTable: "Secciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
