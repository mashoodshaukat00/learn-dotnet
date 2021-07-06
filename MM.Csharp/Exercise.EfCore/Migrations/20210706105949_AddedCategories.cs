using Microsoft.EntityFrameworkCore.Migrations;

namespace Exercise.EfCore.Migrations
{
    public partial class AddedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "IsEnabled", "Name" },
                values: new object[] { 1, "Articles defined in clothing type of merchandise.", true, "Clothing" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "IsEnabled", "Name" },
                values: new object[] { 2, "Articles defined in clothing type of merchandise.", true, "Watches" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
