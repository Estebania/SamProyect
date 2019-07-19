using Microsoft.EntityFrameworkCore.Migrations;

namespace SamSystemWeb.Migrations
{
    public partial class ActualizacionSeccion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdid",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Secciones",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SeccionIdid",
                table: "Estudiantes",
                newName: "SeccionIdID");

            migrationBuilder.RenameIndex(
                name: "IX_Estudiantes_SeccionIdid",
                table: "Estudiantes",
                newName: "IX_Estudiantes_SeccionIdID");

            migrationBuilder.AlterColumn<short>(
                name: "SeccionIdID",
                table: "Estudiantes",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdID",
                table: "Estudiantes",
                column: "SeccionIdID",
                principalTable: "Secciones",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Secciones_SeccionIdID",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Secciones",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SeccionIdID",
                table: "Estudiantes",
                newName: "SeccionIdid");

            migrationBuilder.RenameIndex(
                name: "IX_Estudiantes_SeccionIdID",
                table: "Estudiantes",
                newName: "IX_Estudiantes_SeccionIdid");

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
    }
}
