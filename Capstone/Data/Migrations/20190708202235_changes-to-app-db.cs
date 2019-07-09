using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class changestoappdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26e52cec-66ac-40dd-bf8e-71240c2fd80a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "0fb11a24-b178-4c59-9169-95769fb85afd", 0, "1d54c6c0-b4a7-4b21-985e-b4da1a78dacd", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENLPUFjyRhvPx0qVhFFezZUSd8WGwvrlTkRaypZq1amdh1AC2NMPdJxlH2dPBwlleQ==", null, false, "92a83dc8-7599-4c6a-b4a0-c57df1f60b3c", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "UrlToPurchase", "UserId" },
                values: new object[] { "https://www.gamestop.com/games/the-legend-of-zelda-ocarina-of-time/122505", "0fb11a24-b178-4c59-9169-95769fb85afd" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "UrlToPurchase", "UserId" },
                values: new object[] { "https://finalfantasyxhd.square-enix-games.com/en-us/home/#buy", "0fb11a24-b178-4c59-9169-95769fb85afd" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fb11a24-b178-4c59-9169-95769fb85afd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "26e52cec-66ac-40dd-bf8e-71240c2fd80a", 0, "3e0e096c-7e13-45de-ba8e-ccb27edb33ef", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECuOjwTTUUEQT9VBUUIRDSeIfBkBPT2SauFjjqCkFDl8X7GgEjFrdLXPCEzp+jxwJw==", null, false, "41f524ea-b372-4a68-8c5f-9886be6d7fd6", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "UrlToPurchase", "UserId" },
                values: new object[] { null, "26e52cec-66ac-40dd-bf8e-71240c2fd80a" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "UrlToPurchase", "UserId" },
                values: new object[] { null, "26e52cec-66ac-40dd-bf8e-71240c2fd80a" });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "26e52cec-66ac-40dd-bf8e-71240c2fd80a");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "26e52cec-66ac-40dd-bf8e-71240c2fd80a");
        }
    }
}
