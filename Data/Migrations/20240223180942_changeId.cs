using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class changeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2846775f-37c0-4f5a-8a6c-44101f4691ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e69c7f1-5497-455b-b884-6264b6d263a8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "8a7a0315-33ba-4f05-a8c4-0c22338d8ab4", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "40dd3289-c687-47dd-b0dc-655db3711977", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2846775f-37c0-4f5a-8a6c-44101f4691ea", "15fe8193-ddd9-4dd4-a977-2da1a166806b", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e69c7f1-5497-455b-b884-6264b6d263a8", "2a48a2a1-5640-4c2c-a283-f3bfaadeda58", "User", "user" });
        }
    }
}
