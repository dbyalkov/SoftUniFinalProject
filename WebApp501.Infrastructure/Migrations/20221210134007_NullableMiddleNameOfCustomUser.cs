using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class NullableMiddleNameOfCustomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143b864b-1a23-457c-8e65-596bfae80024", "AQAAAAEAACcQAAAAEKkM7pmkWcqPi18dkp9Gs52QXth5DoZKQNkIsG9+pw4jCx/Sm/z/Mf+rqlxqGXzZkw==", "a2b922c0-eb8b-4984-8f7a-9b221f13e537" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fd8f74e-15cf-4697-b657-22c774f2f540", "AQAAAAEAACcQAAAAEN0qvKcy7HmxWefKnMaQ2ewuh6VSU1rWfjFOEgVPEAZ3se6V6uji+dM2+4KmRyovrg==", "931227a8-3057-4760-a244-43b562ab9dbe" });
        }
    }
}
