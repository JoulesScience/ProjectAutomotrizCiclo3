using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Vehiculo_auto_cami : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "vehiculos",
                newName: "placa_id");

            migrationBuilder.CreateIndex(
                name: "IX_camionetas_placa_id",
                table: "camionetas",
                column: "placa_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_autos_placa_id",
                table: "autos",
                column: "placa_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_autos_vehiculos_placa_id",
                table: "autos",
                column: "placa_id",
                principalTable: "vehiculos",
                principalColumn: "placa_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_camionetas_vehiculos_placa_id",
                table: "camionetas",
                column: "placa_id",
                principalTable: "vehiculos",
                principalColumn: "placa_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_autos_vehiculos_placa_id",
                table: "autos");

            migrationBuilder.DropForeignKey(
                name: "FK_camionetas_vehiculos_placa_id",
                table: "camionetas");

            migrationBuilder.DropIndex(
                name: "IX_camionetas_placa_id",
                table: "camionetas");

            migrationBuilder.DropIndex(
                name: "IX_autos_placa_id",
                table: "autos");

            migrationBuilder.RenameColumn(
                name: "placa_id",
                table: "vehiculos",
                newName: "Id");
        }
    }
}
