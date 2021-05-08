using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryApp.Data.Migrations
{
    public partial class manyToManyExtraField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketplaceProduct_Marketplaces_MarketplacesId",
                table: "MarketplaceProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarketplaceProduct_Products_ProductsId",
                table: "MarketplaceProduct");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "MarketplaceProduct",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "MarketplacesId",
                table: "MarketplaceProduct",
                newName: "MarketplaceId");

            migrationBuilder.RenameIndex(
                name: "IX_MarketplaceProduct_ProductsId",
                table: "MarketplaceProduct",
                newName: "IX_MarketplaceProduct_ProductId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateListed",
                table: "MarketplaceProduct",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketplaceProduct_Marketplaces_MarketplaceId",
                table: "MarketplaceProduct",
                column: "MarketplaceId",
                principalTable: "Marketplaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarketplaceProduct_Products_ProductId",
                table: "MarketplaceProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketplaceProduct_Marketplaces_MarketplaceId",
                table: "MarketplaceProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarketplaceProduct_Products_ProductId",
                table: "MarketplaceProduct");

            migrationBuilder.DropColumn(
                name: "DateListed",
                table: "MarketplaceProduct");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "MarketplaceProduct",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "MarketplaceId",
                table: "MarketplaceProduct",
                newName: "MarketplacesId");

            migrationBuilder.RenameIndex(
                name: "IX_MarketplaceProduct_ProductId",
                table: "MarketplaceProduct",
                newName: "IX_MarketplaceProduct_ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketplaceProduct_Marketplaces_MarketplacesId",
                table: "MarketplaceProduct",
                column: "MarketplacesId",
                principalTable: "Marketplaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarketplaceProduct_Products_ProductsId",
                table: "MarketplaceProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
