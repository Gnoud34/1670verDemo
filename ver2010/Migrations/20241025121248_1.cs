using Microsoft.EntityFrameworkCore.Migrations;

namespace ver2010.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Application",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1",
                column: "ConcurrencyStamp",
                value: "a44d745e-bec8-4e84-ab9f-e07f7a2d99b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2",
                column: "ConcurrencyStamp",
                value: "71a62fda-16b3-4eba-87c3-dcdb00f9ea64");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f8ead19-9daf-4357-a584-b9cc88c940e4", "AQAAAAEAACcQAAAAEIWXGownmBmhsZNbGwpnL1M8xqPGPIY+6B0eV6kT6aXrvczjYNJJDPje1K6AYKJknw==", "799dc449-3c0a-495b-814e-5b43bc7ce7d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39ccd34e-e8b0-403f-9a45-b9e0c7eef1a1", "AQAAAAEAACcQAAAAED5Xj8sDSF9Bkhlg74FyOkufOnLJeiQAf5mLVx/bCZYGUmGIFDf2vOrP2Da0P4IPuw==", "b88b101e-4a2e-41cc-8748-8a82d22c418d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Application",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1",
                column: "ConcurrencyStamp",
                value: "ff23dafc-8de5-4345-ad5b-b2440d92efff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2",
                column: "ConcurrencyStamp",
                value: "95d339fb-b833-4cd5-b7d4-ae25eba82d7f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3bd2d1b-c4dc-4143-aa36-f68d50cf4550", "AQAAAAEAACcQAAAAEDjAapNeaq2IyGDiNQSlvD6P0JigdgJfXoLeFGUTV9jbvjpZhur5D7aECI4WSZAX7Q==", "fffd5877-b4ba-4ca4-8883-ccf4e4c87d1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abc4c832-56d1-4b9c-8c70-9b398827d8b9", "AQAAAAEAACcQAAAAEJDzAX9tU1fAIAo5xqfbL5aDcL3Vp4OhPL5L0wCm63Z6tj9iLY2AUi6E6Atn+VypWw==", "5d40d2de-1188-43dc-887d-423c4ebbdd6a" });
        }
    }
}
