using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class addedurldatatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fb11a24-b178-4c59-9169-95769fb85afd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "668bca97-7208-412b-ae82-38b4f9265457", 0, "151d1dcb-c959-4136-a14c-ff7d860101b5", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBAoABIE/x63x2BLuRHWtH2wQ54O8cxJGXgUyg/eq67tE+F5IvEG+RqGkkWH420Ovg==", null, false, "bad04780-9415-4b9a-8453-869c7ddf04ec", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "668bca97-7208-412b-ae82-38b4f9265457");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "668bca97-7208-412b-ae82-38b4f9265457");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "668bca97-7208-412b-ae82-38b4f9265457");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "668bca97-7208-412b-ae82-38b4f9265457");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "668bca97-7208-412b-ae82-38b4f9265457");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "0fb11a24-b178-4c59-9169-95769fb85afd", 0, "1d54c6c0-b4a7-4b21-985e-b4da1a78dacd", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENLPUFjyRhvPx0qVhFFezZUSd8WGwvrlTkRaypZq1amdh1AC2NMPdJxlH2dPBwlleQ==", null, false, "92a83dc8-7599-4c6a-b4a0-c57df1f60b3c", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "0fb11a24-b178-4c59-9169-95769fb85afd");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "0fb11a24-b178-4c59-9169-95769fb85afd");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "0fb11a24-b178-4c59-9169-95769fb85afd");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "0fb11a24-b178-4c59-9169-95769fb85afd");
        }
    }
}
