using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class changestogamesdescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f83d341-0512-4945-aa05-79dbc6513661");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "7d364cff-f9f8-4793-aa06-07377b797fa4", 0, "f7ada094-a74e-42d4-8a31-08ef15a2aee5", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOvXfvqaT0wudqT8HLCHKT0wjAi0p3QHqrf8VWLBAL3VlmIAPkWuopBOgz8f8HKtDg==", null, false, "ff487a4a-f1df-4bdd-ba56-aee58446a0d1", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Description", "UserId" },
                values: new object[] { "The player plays as a character named Link in the land of Hyrule. The player is on a quest to stop Ganondorf from obtaining the triforce, a sacred relic. Link travels through time and completes dungeons to awaken the sages who can seal away evil.", "7d364cff-f9f8-4793-aa06-07377b797fa4" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Description", "UserId" },
                values: new object[] { "The player plays as Tidus who ends up in a place called Spira after his home is destroyed by a monster known as Sin. There are 7 possible characters in your group that you may switch between, all who have different skills and purposes.", "7d364cff-f9f8-4793-aa06-07377b797fa4" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d364cff-f9f8-4793-aa06-07377b797fa4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "6f83d341-0512-4945-aa05-79dbc6513661", 0, "6cab84a8-2ec7-494f-81cc-71a0b831a106", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN4TxtQ2NnaZe6kjhDw7TXhk3PXvRDX4yUGs5Mjqb/hfhBv74HfXuqoO+SGbNpig3w==", null, false, "26b9dec8-1cd3-4019-9a57-a2973cf46ab3", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Description", "UserId" },
                values: new object[] { "The player plays as a character named Link in the land of Hyrule. The player is on a quest to stop Ganondorf from obtaining the triforce, a sacred relic. Link travels through time and completes dungeons to awaken the sages who can seal away the evil.", "6f83d341-0512-4945-aa05-79dbc6513661" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Description", "UserId" },
                values: new object[] { "The player plays as Tidus who ends up in a place called Spira after his home is destroyed by a monster known as Sin. There are 7 possible characters in your group that you may switch between, all with different skills and purposes.", "6f83d341-0512-4945-aa05-79dbc6513661" });

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
    }
}
