using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class addAdminAuthountication2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4347aa1-ed29-41f5-92c0-4859fcca1cf2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c867c0b4-0f37-4152-b434-7a60ce5853fa", "9bf840bc-95ff-4d2a-9efc-2e31daad3033", "Admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c867c0b4-0f37-4152-b434-7a60ce5853fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4347aa1-ed29-41f5-92c0-4859fcca1cf2", "9591be6b-31e3-4499-9b3a-9d3a2dab49ca", "Admin", "admin" });
        }
    }
}
