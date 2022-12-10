using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class AddedUserColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "MiddleName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "143b864b-1a23-457c-8e65-596bfae80024", "Dimitrov", "AQAAAAEAACcQAAAAEKkM7pmkWcqPi18dkp9Gs52QXth5DoZKQNkIsG9+pw4jCx/Sm/z/Mf+rqlxqGXzZkw==", "a2b922c0-eb8b-4984-8f7a-9b221f13e537" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "MiddleName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fd8f74e-15cf-4697-b657-22c774f2f540", "Nikolaev", "AQAAAAEAACcQAAAAEN0qvKcy7HmxWefKnMaQ2ewuh6VSU1rWfjFOEgVPEAZ3se6V6uji+dM2+4KmRyovrg==", "931227a8-3057-4760-a244-43b562ab9dbe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "442e2d02-93e2-423a-b58c-5c7275c124b3", "AQAAAAEAACcQAAAAEACd9r0eklZoaetmXui0+fa+3+0AhW4ZOIbduqplc2BIfoI3zP8cJTOg76bQ8f1xBg==", "e6cb238c-e506-4c2e-b48b-0cb7bbced3f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c45001f6-6841-4341-a977-7fd6c2db2199", "AQAAAAEAACcQAAAAEJvmQM4ZE9a16NBdBSjgAO4R7jZsR1t50RYV9h3gpsPVGwZ1lytkbAIT31WY9f13AA==", "d5aa4ccd-75eb-41c4-9a7b-ae8019222e72" });
        }
    }
}
