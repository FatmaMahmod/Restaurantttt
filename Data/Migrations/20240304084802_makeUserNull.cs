using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class makeUserNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTables_AspNetUsers_userID",
                table: "BookingTables");

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "BookingTables",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4f7dc67c-fb1d-49d2-bb64-0cadf8419141");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "fee00bd5-0e06-42df-a768-c8bec7237d82");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTables_AspNetUsers_userID",
                table: "BookingTables",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTables_AspNetUsers_userID",
                table: "BookingTables");

            migrationBuilder.AlterColumn<string>(
                name: "userID",
                table: "BookingTables",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ac6a1a7a-895d-4437-82ef-b1ba2993a180");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "03444b95-0674-438b-92ca-372e06ec658f");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTables_AspNetUsers_userID",
                table: "BookingTables",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
