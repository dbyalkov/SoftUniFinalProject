using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class RemoveAgeFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77ca963e-a46b-49f9-b173-c4343d65ba0d", "AQAAAAEAACcQAAAAEAAXcI7tN7PLw7/e8UDgXi7vbPAGkWyUkCuxdB6aXryLBVHlfvOM1z6uaQLYw4y2jw==", "8364c8b1-c403-4712-b079-b710fc724536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08fe00cd-19af-4e68-9289-2dcdacf0d572", "AQAAAAEAACcQAAAAEKtDNNmeKlGTGiKfOSRX2eis+1hKCxXwyTkpzHqNdKVTke6NrVktkPRMtBuJ9q+f1g==", "a2bce465-953b-44f0-bc7c-b9d34139d896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c609c13a-247d-442b-85b6-e6d03ecf2bee", "AQAAAAEAACcQAAAAEJwIOKvgAy5KTQ1WQTJOToimAHSS0QO1T6ppJu73S8lSrWGd4dQcXL+7l98hE5aGMA==", "2a05f06f-5ac1-4094-825a-5cbe2e68bfa6" });
        }
    }
}
