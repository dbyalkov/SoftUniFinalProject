using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ChangeInCocktailAndImageEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GlassId",
                table: "Cocktails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GlassId",
                table: "Cocktails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33cfc67-cdec-429e-9ca0-ab480cf4bd01", "AQAAAAEAACcQAAAAEBAhssnd1dohVJnnF3zg5OxIoMPgh5UvGSO12ce7dnnGLHpVW4TUni/bXgTR+u9jOQ==", "5174a516-8b96-4f2e-a563-020f13afa1ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2894bdf-baed-4b5f-a7d0-3ab53e0aeaaf", "AQAAAAEAACcQAAAAEOpi3BOTgLu0/vye+8RzVHc58AdP3LKNLaBaOy9gQc6EvvkTVUx3NwyPwltlpmOlEg==", "27ef03c5-1bf5-4bda-9c12-5e7f659341da" });
        }
    }
}
