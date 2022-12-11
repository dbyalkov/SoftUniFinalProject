using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class AddedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf6fdee4-5d41-45cb-a30f-9f40f4a39047", "AQAAAAEAACcQAAAAENLOQimYz3OLkiehZvFcBnvyvLTiQoUX6MYZJcnCupCV9W/5khge4328bv/uGt50Gw==", "fbbdbc1d-1365-40e2-a6b1-0ed293c858f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2a887e-8f53-48a4-95d5-805ea430eb49", "AQAAAAEAACcQAAAAEJBg4xohcg6LGWqiNfKlyGHflzArAiRBWvuI9N74LMjMeKs2qA6/i2aksaAw9oiswA==", "f7233c94-d24c-4b26-a39f-9dfeda7e4280" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "829f99ab-a753-46aa-9b47-0cd34d303f53", "admin@mail.com", false, false, null, "Great", "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELWJ8sWHoba6HVajzMKNK2kmMa7G/GxAuzrMwBpGjsr987BLBssyrA5M/FM62u8LBw==", null, false, "b8bd8e8a-6c63-4b69-80c8-41ec4e552e64", false, "admnin" });

            migrationBuilder.InsertData(
                table: "Bartenders",
                columns: new[] { "Id", "Age", "FirstName", "IsDeleted", "LastName", "UserId" },
                values: new object[] { 4, 33, "Great", false, "Admin", "bcb4f072-ecca-43c9-ab26-c060c6f364e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bartenders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc01027-f3da-4ba0-af7e-e2c8a81c66b8", "AQAAAAEAACcQAAAAEAcilqUM9KNx8r7+TDpPE8cfxPgQc0Bg3Tk6z0uU2gpbDJxmBWpgAgos3vAbayIFHQ==", "522f9c49-e69e-4971-9c00-2f237dc872b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9456b197-3d5d-4025-a6f5-e2e3915ae79a", "AQAAAAEAACcQAAAAEFQk6KZeyw/eM7ccZmoG1ZCvGjSHqfbiDTtJmf/CiKis7I9BN5NQSAw4uPCVn/JUzw==", "f76e69fd-b54d-4508-9823-8fd6c067903f" });
        }
    }
}
