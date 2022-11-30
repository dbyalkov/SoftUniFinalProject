using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ChangedAnotherImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe0ae1e5-fcb2-4452-864a-d7acb18b83d0", "AQAAAAEAACcQAAAAEFGY6xJb3JvNCE656kF4Esc3NyvHh6/VhhQjT1mVBc9bWEIzPErptMsGyBN7a7GyPg==", "78f1cb18-8fb1-41e4-9612-de25e2951127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48b59469-5b2a-4ff8-9eb7-d4a00633b6ef", "AQAAAAEAACcQAAAAEPF2SYg1zRozeYQfZ7YS7frcOssDhuYSs5hEiFgV6KPTJYwVMfCp3uxNNpj3H5j3Kw==", "3c18e095-a7cd-4ec1-8258-eb42fb2a98d7" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://cdn.diffords.com/contrib/stock-images/2017/1/16/20177572d2119c567079c338b14db4eb375e.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b57378f7-42cb-4e2e-b180-aced08b9360c", "AQAAAAEAACcQAAAAECrsD2rAJLKx96lGUUMnytyGIDFMvtargDHYuIUQkWmcqsDqKYwnc2xpPxTY7uPf8Q==", "6b643971-2d41-4e0d-8e70-226ec0323daf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94b1afcd-b56d-4784-8ee8-85353300fa69", "AQAAAAEAACcQAAAAECTSt95Ua7ujxV506pgRiJ8A21I+S8SYM073gvyjyiFMC2uFETQZ45nTZgWvyE736Q==", "a6a9c2db-5600-435e-8614-d2f1c1ebb30e" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://unsplash.com/photos/TgQkxQc-t_U");
        }
    }
}
