using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tag",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Game",
                newName: "GameId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tag",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "170095b4-79e5-4653-9b03-ece90dbd7ca8", 0, "604cd9d4-4332-4261-9377-36a6d3a8f5fb", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELlbNKj8na1hFCQ5/zuIqNAFpvkBUulm6f5QFsQtdDcUTBP5SPzaQk65M636lknKew==", null, false, "779484fe-64ff-4266-8a0b-c3564c9bf657", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "ApplicationUserId", "Description", "EsrbRating", "Genre", "HavePlayed", "NumberOfPlayers", "Platform", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, null, "The player plays as a character named Link in the land of Hyrule. The player is on a quest to stop Ganondorf from obtaining the triforce, a sacred relic. Link travels through time and completes dungeons to awaken the sages who can seal away the evil.", "E", "action-adventure", false, "Single player", "Nintendo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Legend of Zelda: Ocarina of Time" },
                    { 2, null, "The player plays as Tidus who ends up in a place called Spira after his home is destroyed by a monster known as Sin. There are 7 possible characters in your group that you may switch between, all with different skills and purposes.", "T", "RPG", false, "Single Player", "Playstation, Xbox", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy X" }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "TagId", "GameId", "Title" },
                values: new object[,]
                {
                    { 1, null, "RPG" },
                    { 2, null, "Adventure" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "170095b4-79e5-4653-9b03-ece90dbd7ca8");

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Tag",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Game",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Tag",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
