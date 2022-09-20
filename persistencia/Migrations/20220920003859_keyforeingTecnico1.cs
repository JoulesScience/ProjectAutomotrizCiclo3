using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class keyforeingTecnico1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tecnicos_Identificaion_id",
                table: "tecnicos",
                column: "Identificaion_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tecnicos_personas_Identificaion_id",
                table: "tecnicos",
                column: "Identificaion_id",
                principalTable: "personas",
                principalColumn: "Identificaion_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tecnicos_personas_Identificaion_id",
                table: "tecnicos");

            migrationBuilder.DropIndex(
                name: "IX_tecnicos_Identificaion_id",
                table: "tecnicos");
        }
    }
}
