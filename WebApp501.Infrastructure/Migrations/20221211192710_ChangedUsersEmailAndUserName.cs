using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ChangedUsersEmailAndUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b69b2ab-8872-41ae-aba2-3c4dc2251721", "DOOMAR@ABV.BG", "AQAAAAEAACcQAAAAEGy/iFAX+rt9l+X5ggTKJFBXtkka7ZkH86cCkC7wJZbm68na+J4vIzpFbviCxxxhIQ==", "beda05f7-85ac-4913-b494-87583c0dd73e", "doomar@abv.bg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "de08a02d-8f5d-4003-bdaf-4fe2194a6ead", "DBYALKOV@ABV.BG", "AQAAAAEAACcQAAAAEPxMAnQTUZ5aRhjlv8YN80P20l03AS4CXHGIhAF3dCaB3VowIzAsdH11PlwnpguNPg==", "23fba16e-230c-4e34-b1e5-c5d40fcd5ba4", "dbyalkov@abv.bg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5c139c00-fe99-435c-b6cf-bca0a9c5463f", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEG+SbfT/wDDPEYK79E3ciI9LCEjZmEhFWdemfqWZIyqDJNjZFtnsIy9ALDC5JPJTbg==", "857b084a-550f-4d93-b413-fb1ed9241cee", "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bf6fdee4-5d41-45cb-a30f-9f40f4a39047", "D00M3R", "AQAAAAEAACcQAAAAENLOQimYz3OLkiehZvFcBnvyvLTiQoUX6MYZJcnCupCV9W/5khge4328bv/uGt50Gw==", "fbbdbc1d-1365-40e2-a6b1-0ed293c858f4", "d00m3r" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ac2a887e-8f53-48a4-95d5-805ea430eb49", "DBYALKOV", "AQAAAAEAACcQAAAAEJBg4xohcg6LGWqiNfKlyGHflzArAiRBWvuI9N74LMjMeKs2qA6/i2aksaAw9oiswA==", "f7233c94-d24c-4b26-a39f-9dfeda7e4280", "dbyalkov" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "829f99ab-a753-46aa-9b47-0cd34d303f53", "ADMIN", "AQAAAAEAACcQAAAAELWJ8sWHoba6HVajzMKNK2kmMa7G/GxAuzrMwBpGjsr987BLBssyrA5M/FM62u8LBw==", "b8bd8e8a-6c63-4b69-80c8-41ec4e552e64", "admnin" });
        }
    }
}
