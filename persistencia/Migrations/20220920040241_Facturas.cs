using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Facturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tecnicos",
                newName: "Tecnico_id");

            migrationBuilder.RenameColumn(
                name: "Placa_id",
                table: "Facturas",
                newName: "placa_id");

            migrationBuilder.RenameColumn(
                name: "Cliente_id",
                table: "Facturas",
                newName: "Factura_id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Facturas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Factura_id",
                table: "Facturas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "Factura_id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_placa_id",
                table: "Facturas",
                column: "placa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Tecnico_id",
                table: "Facturas",
                column: "Tecnico_id");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_Factura_id",
                table: "clientes",
                column: "Factura_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_Facturas_Factura_id",
                table: "clientes",
                column: "Factura_id",
                principalTable: "Facturas",
                principalColumn: "Factura_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_clientes_ClienteId",
                table: "Facturas",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_tecnicos_Tecnico_id",
                table: "Facturas",
                column: "Tecnico_id",
                principalTable: "tecnicos",
                principalColumn: "Tecnico_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_vehiculos_placa_id",
                table: "Facturas",
                column: "placa_id",
                principalTable: "vehiculos",
                principalColumn: "placa_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_Facturas_Factura_id",
                table: "clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_clientes_ClienteId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_tecnicos_Tecnico_id",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_vehiculos_placa_id",
                table: "Facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_placa_id",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_Tecnico_id",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_clientes_Factura_id",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "Tecnico_id",
                table: "tecnicos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "placa_id",
                table: "Facturas",
                newName: "Placa_id");

            migrationBuilder.RenameColumn(
                name: "Factura_id",
                table: "Facturas",
                newName: "Cliente_id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Facturas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Cliente_id",
                table: "Facturas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "Id");
        }
    }
}
