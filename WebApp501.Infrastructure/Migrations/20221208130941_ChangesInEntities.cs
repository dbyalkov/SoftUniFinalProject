using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ChangesInEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e93b21-4e94-4603-b71b-64475bbeb0b8", "AQAAAAEAACcQAAAAENSGnG4y+jDNDeTfTFhJMDjoMhmBNwLn9ctNgUTtsVgf+7Zbk3HH71i3RmXkzQE7YA==", "a55e61b3-bd43-44db-930e-fa5d40f84e5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fb6ea98-ca92-494a-9c0f-98c1014f20a8", "AQAAAAEAACcQAAAAEIPRYXY3n2CR9bCbyLJ3yYfVnTPOliG+gDC2zq+L5bvCIjD3RyqKr31DkKyGzraQ1Q==", "325384cc-d577-47fa-a4fc-be25d12e8088" });
        }
    }
}
