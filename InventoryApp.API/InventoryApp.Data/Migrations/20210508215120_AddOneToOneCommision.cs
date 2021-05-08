using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryApp.Data.Migrations
{
    public partial class AddOneToOneCommision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommisionRate = table.Column<double>(type: "float", nullable: false),
                    MarketplaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comission_Marketplaces_MarketplaceId",
                        column: x => x.MarketplaceId,
                        principalTable: "Marketplaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comission_MarketplaceId",
                table: "Comission",
                column: "MarketplaceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comission");
        }
    }
}
