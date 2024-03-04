using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yummy.Data.Migrations
{
    public partial class AddUserToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "BookingTables",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_BookingTables_userID",
                table: "BookingTables",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTables_AspNetUsers_userID",
                table: "BookingTables",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTables_AspNetUsers_userID",
                table: "BookingTables");

            migrationBuilder.DropIndex(
                name: "IX_BookingTables_userID",
                table: "BookingTables");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "BookingTables");

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "69b9368b-2629-4bb8-a5e0-d927638e2ac6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9c13bf5b-bba2-4b14-be47-06a420bc8d62");
        }
    }
}
