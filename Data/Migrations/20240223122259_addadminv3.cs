using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addadminv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03553b07-71c9-46ac-b744-a0a183449e94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66e6b1b3-5bd8-4887-98a5-6f01c4da1d9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c4d7292-ddb1-4cd7-a0ef-426bf63720cd", "f6bbf28d-3e6e-46c5-814b-9eb629b44d7b", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2b88042-cf56-4f5d-b87d-391b6e337b77", "ecf5e2ab-1d35-40d6-96ae-6823f667b446", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4d7292-ddb1-4cd7-a0ef-426bf63720cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2b88042-cf56-4f5d-b87d-391b6e337b77");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03553b07-71c9-46ac-b744-a0a183449e94", "ff2d1c46-b3cd-4749-a2cc-f7cb0173f730", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66e6b1b3-5bd8-4887-98a5-6f01c4da1d9a", "c3374c2d-b3be-47dc-b9b1-727c37d2f2cf", "Admin", "admin" });
        }
    }
}
