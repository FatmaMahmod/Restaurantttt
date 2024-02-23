using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addtestuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "224dd8e1-75a9-4f16-af1f-9e027ee4ec93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46b4d0ea-4b16-442e-88b2-b4d2b7dfe1e0", "14b9992d-34b3-42b7-b7c4-d40840fc00fe", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e165800-38b5-4235-9a9e-aabc1229f702", "a9b90fbb-f01f-4621-9b08-dd9d7d4f127b", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46b4d0ea-4b16-442e-88b2-b4d2b7dfe1e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e165800-38b5-4235-9a9e-aabc1229f702");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "224dd8e1-75a9-4f16-af1f-9e027ee4ec93", "24866297-0bd9-4f9b-a22c-f9c2a2947c0f", "Admin", "admin" });
        }
    }
}
