using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kuari.Blog.Repository.Migrations
{
    public partial class CategorySeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Yazılım Dünyasinda Kariyer Fırsatları", "Yazılım", true },
                    { 2, "Sinema ve Tiyatro Dünyasındaki Son Gelişmeler", "Sinema", true },
                    { 3, "Sağlıklı Hayat", "Sağlık", true },
                    { 4, "Ulusal ve Uluslararası Spor Müsabakaları", "Spor", true },
                    { 5, "Ulusal Siber Güvenliğin Önemi", "Siber Güvenlik", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
