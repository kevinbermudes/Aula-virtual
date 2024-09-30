using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webvs2.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_Alumnos_AlumnoId",
                table: "Tareas");

            migrationBuilder.DropIndex(
                name: "IX_Tareas_AlumnoId",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Tareas");

            migrationBuilder.AlterColumn<int>(
                name: "FechaEx",
                table: "Tareas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AddColumn<int>(
                name: "TareaId",
                table: "Alumnos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_TareaId",
                table: "Alumnos",
                column: "TareaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Tareas_TareaId",
                table: "Alumnos",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Tareas_TareaId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_TareaId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "TareaId",
                table: "Alumnos");

            migrationBuilder.AlterColumn<string>(
                name: "FechaEx",
                table: "Tareas",
                type: "varchar(5)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Tareas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_AlumnoId",
                table: "Tareas",
                column: "AlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_Alumnos_AlumnoId",
                table: "Tareas",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
