using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class modelchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87cbe80-30ef-4434-ae8b-19b5e932255f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "6f83d341-0512-4945-aa05-79dbc6513661", 0, "6cab84a8-2ec7-494f-81cc-71a0b831a106", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN4TxtQ2NnaZe6kjhDw7TXhk3PXvRDX4yUGs5Mjqb/hfhBv74HfXuqoO+SGbNpig3w==", null, false, "26b9dec8-1cd3-4019-9a57-a2973cf46ab3", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "6f83d341-0512-4945-aa05-79dbc6513661");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "6f83d341-0512-4945-aa05-79dbc6513661");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "6f83d341-0512-4945-aa05-79dbc6513661");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "6f83d341-0512-4945-aa05-79dbc6513661");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f83d341-0512-4945-aa05-79dbc6513661");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "e87cbe80-30ef-4434-ae8b-19b5e932255f", 0, "3bb9042f-578e-48d5-923f-0ab8de8338e2", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOtpT2fUlzS1ItlcFAxm8wWeyteujPY62+FlUVuJF3vp0vseBqQk5iq3rxGrZ+Efqw==", null, false, "4ddfb322-e1ee-4f37-8542-020e47c80fe2", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "e87cbe80-30ef-4434-ae8b-19b5e932255f");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "e87cbe80-30ef-4434-ae8b-19b5e932255f");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "e87cbe80-30ef-4434-ae8b-19b5e932255f");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "e87cbe80-30ef-4434-ae8b-19b5e932255f");
        }
    }
}
