using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class addedpurchasetogamemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d364cff-f9f8-4793-aa06-07377b797fa4");

            migrationBuilder.AddColumn<string>(
                name: "UrlToPurchase",
                table: "Game",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "26e52cec-66ac-40dd-bf8e-71240c2fd80a", 0, "3e0e096c-7e13-45de-ba8e-ccb27edb33ef", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECuOjwTTUUEQT9VBUUIRDSeIfBkBPT2SauFjjqCkFDl8X7GgEjFrdLXPCEzp+jxwJw==", null, false, "41f524ea-b372-4a68-8c5f-9886be6d7fd6", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "26e52cec-66ac-40dd-bf8e-71240c2fd80a");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "26e52cec-66ac-40dd-bf8e-71240c2fd80a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26e52cec-66ac-40dd-bf8e-71240c2fd80a");

            migrationBuilder.DropColumn(
                name: "UrlToPurchase",
                table: "Game");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "7d364cff-f9f8-4793-aa06-07377b797fa4", 0, "f7ada094-a74e-42d4-8a31-08ef15a2aee5", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOvXfvqaT0wudqT8HLCHKT0wjAi0p3QHqrf8VWLBAL3VlmIAPkWuopBOgz8f8HKtDg==", null, false, "ff487a4a-f1df-4bdd-ba56-aee58446a0d1", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "7d364cff-f9f8-4793-aa06-07377b797fa4");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "7d364cff-f9f8-4793-aa06-07377b797fa4");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "7d364cff-f9f8-4793-aa06-07377b797fa4");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "7d364cff-f9f8-4793-aa06-07377b797fa4");
        }
    }
}
