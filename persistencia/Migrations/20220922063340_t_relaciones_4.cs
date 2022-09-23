using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class t_relaciones_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_autos_clientes_ClienteId",
                table: "autos");

            migrationBuilder.DropForeignKey(
                name: "FK_camionetas_clientes_ClienteId",
                table: "camionetas");

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

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_ClienteId",
                table: "vehiculos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculos_clientes_ClienteId",
                table: "vehiculos",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculos_clientes_ClienteId",
                table: "vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_vehiculos_ClienteId",
                table: "vehiculos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "vehiculos");

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
        }
    }
}
