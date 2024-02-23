using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addcorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b1c627f-2908-4d09-ad80-fed2ac950766");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "224dd8e1-75a9-4f16-af1f-9e027ee4ec93", "24866297-0bd9-4f9b-a22c-f9c2a2947c0f", "Admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "224dd8e1-75a9-4f16-af1f-9e027ee4ec93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b1c627f-2908-4d09-ad80-fed2ac950766", "ae19861f-314e-4cb3-a867-5631639c7dab", "Admin", "admin" });
        }
    }
}
