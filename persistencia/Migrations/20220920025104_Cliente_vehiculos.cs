using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Cliente_vehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "camionetas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "autos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_placa_id",
                table: "clientes",
                column: "placa_id");

            migrationBuilder.CreateIndex(
                name: "IX_camionetas_ClienteId",
                table: "camionetas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_autos_ClienteId",
                table: "autos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_autos_clientes_ClienteId",
                table: "autos",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_camionetas_clientes_ClienteId",
                table: "camionetas",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_vehiculos_placa_id",
                table: "clientes",
                column: "placa_id",
                principalTable: "vehiculos",
                principalColumn: "placa_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_autos_clientes_ClienteId",
                table: "autos");

            migrationBuilder.DropForeignKey(
                name: "FK_camionetas_clientes_ClienteId",
                table: "camionetas");

            migrationBuilder.DropForeignKey(
                name: "FK_clientes_vehiculos_placa_id",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_clientes_placa_id",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_camionetas_ClienteId",
                table: "camionetas");

            migrationBuilder.DropIndex(
                name: "IX_autos_ClienteId",
                table: "autos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "camionetas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "autos");
        }
    }
}
