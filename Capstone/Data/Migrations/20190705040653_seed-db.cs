using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class seeddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "170095b4-79e5-4653-9b03-ece90dbd7ca8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "cfd71a10-cd0f-4af7-bf2b-523a141f229a", 0, "7968509c-a7ea-427e-8c68-3022e1fe7402", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN2LCCAKHSbadeJrpOvrcdbWwly3IohHdmNG3m4Q5YaEEcH6bWgpVlylHO/aMsjQLQ==", null, false, "2e7ef79c-fefa-4f3c-ad24-6ca4f667ff42", false, "admin@admin.com", "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfd71a10-cd0f-4af7-bf2b-523a141f229a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "170095b4-79e5-4653-9b03-ece90dbd7ca8", 0, "604cd9d4-4332-4261-9377-36a6d3a8f5fb", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELlbNKj8na1hFCQ5/zuIqNAFpvkBUulm6f5QFsQtdDcUTBP5SPzaQk65M636lknKew==", null, false, "779484fe-64ff-4266-8a0b-c3564c9bf657", false, "admin@admin.com", "admin", "admin" });
        }
    }
}
