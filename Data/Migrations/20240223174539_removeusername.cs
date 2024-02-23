using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class removeusername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4d7292-ddb1-4cd7-a0ef-426bf63720cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2b88042-cf56-4f5d-b87d-391b6e337b77");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2846775f-37c0-4f5a-8a6c-44101f4691ea", "15fe8193-ddd9-4dd4-a977-2da1a166806b", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e69c7f1-5497-455b-b884-6264b6d263a8", "2a48a2a1-5640-4c2c-a283-f3bfaadeda58", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2846775f-37c0-4f5a-8a6c-44101f4691ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e69c7f1-5497-455b-b884-6264b6d263a8");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c4d7292-ddb1-4cd7-a0ef-426bf63720cd", "f6bbf28d-3e6e-46c5-814b-9eb629b44d7b", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2b88042-cf56-4f5d-b87d-391b6e337b77", "ecf5e2ab-1d35-40d6-96ae-6823f667b446", "User", "user" });
        }
    }
}
