using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class keyforeingCliente1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes",
                column: "Identificaion_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes",
                column: "Identificaion_id");
        }
    }
}
