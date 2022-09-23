using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class t_relaciones_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Identificaion_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Identificaion_id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    placa_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cilindraje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_combustible = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.placa_id);
                });

            migrationBuilder.CreateTable(
                name: "tecnicos",
                columns: table => new
                {
                    Tecnico_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificaion_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tecnicos", x => x.Tecnico_id);
                    table.ForeignKey(
                        name: "FK_tecnicos_personas_Identificaion_id",
                        column: x => x.Identificaion_id,
                        principalTable: "personas",
                        principalColumn: "Identificaion_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificaion_id = table.Column<int>(type: "int", nullable: false),
                    placa_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientes_personas_Identificaion_id",
                        column: x => x.Identificaion_id,
                        principalTable: "personas",
                        principalColumn: "Identificaion_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_clientes_vehiculos_placa_id",
                        column: x => x.placa_id,
                        principalTable: "vehiculos",
                        principalColumn: "placa_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "autos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placa_id = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_autos_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_autos_vehiculos_placa_id",
                        column: x => x.placa_id,
                        principalTable: "vehiculos",
                        principalColumn: "placa_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "camionetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Platon = table.Column<bool>(type: "bit", nullable: false),
                    Transmision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placa_id = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_camionetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_camionetas_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_camionetas_vehiculos_placa_id",
                        column: x => x.placa_id,
                        principalTable: "vehiculos",
                        principalColumn: "placa_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Factura_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    filtro_aire = table.Column<bool>(type: "bit", nullable: false),
                    filtro_Gasolina = table.Column<bool>(type: "bit", nullable: false),
                    Cambio_aceite = table.Column<bool>(type: "bit", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Factura_id);
                    table.ForeignKey(
                        name: "FK_Facturas_clientes_Id",
                        column: x => x.Id,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_autos_ClienteId",
                table: "autos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_autos_placa_id",
                table: "autos",
                column: "placa_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_camionetas_ClienteId",
                table: "camionetas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_camionetas_placa_id",
                table: "camionetas",
                column: "placa_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes",
                column: "Identificaion_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_placa_id",
                table: "clientes",
                column: "placa_id");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Id",
                table: "Facturas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tecnicos_Identificaion_id",
                table: "tecnicos",
                column: "Identificaion_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autos");

            migrationBuilder.DropTable(
                name: "camionetas");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "tecnicos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "vehiculos");
        }
    }
}
