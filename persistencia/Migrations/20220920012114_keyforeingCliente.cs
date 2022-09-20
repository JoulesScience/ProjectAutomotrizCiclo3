using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class keyforeingCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes",
                column: "Identificaion_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_personas_Identificaion_id",
                table: "clientes",
                column: "Identificaion_id",
                principalTable: "personas",
                principalColumn: "Identificaion_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_personas_Identificaion_id",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_clientes_Identificaion_id",
                table: "clientes");
        }
    }
}
