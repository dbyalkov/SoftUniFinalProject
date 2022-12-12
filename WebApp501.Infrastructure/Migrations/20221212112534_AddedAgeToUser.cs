using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class AddedAgeToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b69b2ab-8872-41ae-aba2-3c4dc2251721", "AQAAAAEAACcQAAAAEGy/iFAX+rt9l+X5ggTKJFBXtkka7ZkH86cCkC7wJZbm68na+J4vIzpFbviCxxxhIQ==", "beda05f7-85ac-4913-b494-87583c0dd73e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de08a02d-8f5d-4003-bdaf-4fe2194a6ead", "AQAAAAEAACcQAAAAEPxMAnQTUZ5aRhjlv8YN80P20l03AS4CXHGIhAF3dCaB3VowIzAsdH11PlwnpguNPg==", "23fba16e-230c-4e34-b1e5-c5d40fcd5ba4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c139c00-fe99-435c-b6cf-bca0a9c5463f", "AQAAAAEAACcQAAAAEG+SbfT/wDDPEYK79E3ciI9LCEjZmEhFWdemfqWZIyqDJNjZFtnsIy9ALDC5JPJTbg==", "857b084a-550f-4d93-b413-fb1ed9241cee" });
        }
    }
}
