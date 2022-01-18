using Microsoft.EntityFrameworkCore.Migrations;

namespace backendProiect.Migrations
{
    public partial class AddedPriceFoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PriceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_PriceId",
                table: "Foods",
                column: "PriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Prices_PriceId",
                table: "Foods",
                column: "PriceId",
                principalTable: "Prices",
                principalColumn: "PriceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Prices_PriceId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Foods_PriceId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Foods");
        }
    }
}
