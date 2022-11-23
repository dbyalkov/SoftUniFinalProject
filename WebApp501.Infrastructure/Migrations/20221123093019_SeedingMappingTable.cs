using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class SeedingMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c4d36f8-d275-46ed-bc7d-b100edb7ebdd", "AQAAAAEAACcQAAAAEHfKiTTC23v2kvHRpwPnGSzCz+GTV9yvdqpOcxXOYCbIcXZs+5VTeo5HUGt5C2V8SQ==", "d061fcac-2629-4b6f-84b6-2be4c8947cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "498056fa-1c05-4502-bcb8-05785c5abdb5", "AQAAAAEAACcQAAAAELT4M/kW1Qjvugry8Zz2lyszh5CdeSPpUmQFdw0eY/8h9PC5G/pcCphgrBeLj6YxzQ==", "bf21dcc7-4b8f-43ec-8dc6-d7cbc1895d7c" });

            migrationBuilder.InsertData(
                table: "CocktailsImages",
                columns: new[] { "CocktailId", "ImageId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 4 },
                    { 7, 5 },
                    { 8, 6 },
                    { 9, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CocktailsImages",
                keyColumns: new[] { "CocktailId", "ImageId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1ed5a42-d8f8-4d87-b4a9-52688939d9ab", "AQAAAAEAACcQAAAAEDaQGZUmUaLJcdnrVlDdIqRO+9HKqxAQhIxxztleLdglMm+FxXMj0lrAEdqhn4piuA==", "16d735fa-92f9-4626-84d6-476686b3fe80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "207c89e1-73be-4bf1-b341-6d348c220f5c", "AQAAAAEAACcQAAAAEMa3F5XVCrQQMeUrbkWjYJyhztCBk4qvQrgknuQLdpUJVTdfiDDz+ho+FYlkkgJjow==", "daf555ff-30c1-4058-a8f0-929e3fa2bbab" });
        }
    }
}
