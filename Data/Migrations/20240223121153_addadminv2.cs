using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addadminv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1650181a-4eb1-48b4-b6a1-706d21f84f3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f855acc2-9ce4-4df9-b032-abe3c219be79");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03553b07-71c9-46ac-b744-a0a183449e94", "ff2d1c46-b3cd-4749-a2cc-f7cb0173f730", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66e6b1b3-5bd8-4887-98a5-6f01c4da1d9a", "c3374c2d-b3be-47dc-b9b1-727c37d2f2cf", "Admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1650181a-4eb1-48b4-b6a1-706d21f84f3f", "657b5e18-698b-4574-9b9a-885a29e9c1d3", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f855acc2-9ce4-4df9-b032-abe3c219be79", "ba183aa5-c2f8-41be-b50e-a55cc4e5e396", "User", "user" });
        }
    }
}
