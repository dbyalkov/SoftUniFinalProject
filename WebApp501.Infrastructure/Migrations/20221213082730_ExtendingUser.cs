using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ExtendingUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bartenders");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "333f5037-5908-4120-b43a-e8fbc9048e56", "AQAAAAEAACcQAAAAEMtr9FisNRodYxiIWFRMPECmiQYR0MKbiykICPka7lXvMWjqVrYka+R31OYHr09ypQ==", "c67e39eb-84cb-4e65-bd5f-2124a6a0303d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ab91eff-c439-4ca0-b8cf-211fb6391edb", "AQAAAAEAACcQAAAAEB2RE9NUVhI1e5wHh1ZNTej/0zgW2Y224vrLhvDSPtePIHdH4Oyn4t6wxqqvwLjzKg==", "a524ea82-7e7b-41e6-9a22-374703e54802" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad7a8e90-1c44-430f-9199-a7cda5b03bb7", "AQAAAAEAACcQAAAAEMNWtP7s5nwxP0r6wnWC04HtOPSqa1HQzTl/+9ouv/eeJ9w7LE1zkWVMxyBzS1Cd0g==", "5075a2f0-3cad-40f6-864d-26831639c295" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bartenders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09bd55f7-1027-4422-afc1-1336f7ca2d6c", "AQAAAAEAACcQAAAAEGugZ0tneCLJDf/wKXrIP9lRUw6tUg+M8ZplYSP8RV693639NYACLZApy031aA3+sg==", "87593415-f8d6-4bc5-b262-3ce669e797e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39b67afe-af21-4420-8408-218b36b8f803", "AQAAAAEAACcQAAAAEFm1unmTttcxbdIiDggwPcePrTE+odHnk0xJ5//NzDNoDLkFqXJHyt1Edpznb9YAZw==", "82090113-2a0e-40d3-9a6b-22e4dbf48a68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f59cf3c-6c24-40a5-84a8-f1b7e9e35294", "AQAAAAEAACcQAAAAEPNVokjTZFQEn8JnYmTNquEqTSZ+bxi+jYMEF78ASJinF81S/qUw/aluYqyg2yvLfA==", "6e4ac389-5d86-407f-b18b-6f2a0c94a2c6" });
        }
    }
}
