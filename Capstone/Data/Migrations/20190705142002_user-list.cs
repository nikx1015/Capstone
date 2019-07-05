using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Data.Migrations
{
    public partial class userlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3f370b2-a703-4c5c-b785-7d0ab4a28635");

            migrationBuilder.CreateTable(
                name: "UserList",
                columns: table => new
                {
                    UserListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserList", x => x.UserListId);
                    table.ForeignKey(
                        name: "FK_UserList_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserList_GameId",
                table: "UserList",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserList");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e87cbe80-30ef-4434-ae8b-19b5e932255f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "a3f370b2-a703-4c5c-b785-7d0ab4a28635", 0, "9fccb5b8-3811-4d98-aafb-ab0794851871", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENa/usMMH0xIDNRLLUrCcCPgAXGq+vOSDe9u0s9rsbZB6W6l5NqP7vEZ0Q+5zCAU9Q==", null, false, "4793b0e7-7c3e-4e3b-b558-ed59ae0b2e21", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "UserId",
                value: "a3f370b2-a703-4c5c-b785-7d0ab4a28635");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "UserId",
                value: "a3f370b2-a703-4c5c-b785-7d0ab4a28635");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 1,
                column: "UserId",
                value: "a3f370b2-a703-4c5c-b785-7d0ab4a28635");

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "TagId",
                keyValue: 2,
                column: "UserId",
                value: "a3f370b2-a703-4c5c-b785-7d0ab4a28635");
        }
    }
}
