using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class addedusertomodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_AspNetUsers_ApplicationUserId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_ApplicationUserId",
                table: "Game");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "170095b4-79e5-4653-9b03-ece90dbd7ca8");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Game");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tag",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Game",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "10433354-38b6-46bd-9197-5c642e116c62", 0, "93c52249-0870-47b0-811c-189ffab0daa9", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJZOARWgSu6v1/Y0S7kZnhptzvO4jhxN5binJBqrjg/Xa5nWpTQ087rIfVFEI6NdkQ==", null, false, "4256bee4-6d1b-4ddd-abe8-b59b5bf38629", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "10433354-38b6-46bd-9197-5c642e116c62");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "10433354-38b6-46bd-9197-5c642e116c62");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "10433354-38b6-46bd-9197-5c642e116c62");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "10433354-38b6-46bd-9197-5c642e116c62");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_UserId",
                table: "Tag",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_UserId",
                table: "Game",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_AspNetUsers_UserId",
                table: "Game",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_AspNetUsers_UserId",
                table: "Tag",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_AspNetUsers_UserId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_AspNetUsers_UserId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_UserId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Game_UserId",
                table: "Game");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10433354-38b6-46bd-9197-5c642e116c62");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Game");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Game",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "170095b4-79e5-4653-9b03-ece90dbd7ca8", 0, "604cd9d4-4332-4261-9377-36a6d3a8f5fb", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELlbNKj8na1hFCQ5/zuIqNAFpvkBUulm6f5QFsQtdDcUTBP5SPzaQk65M636lknKew==", null, false, "779484fe-64ff-4266-8a0b-c3564c9bf657", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Game_ApplicationUserId",
                table: "Game",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_AspNetUsers_ApplicationUserId",
                table: "Game",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
