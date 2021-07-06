using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise.EfCore.Migrations
{
    public partial class AddedAProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity", "Title" },
                values: new object[] { 1L, 1, "Round neck regular fit t-shirt", "Google.com", "T-Shirt", 24.02m, 100, "West Minister Tee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
