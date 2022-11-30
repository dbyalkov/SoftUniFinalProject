using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ChangedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de9fb74-e226-4625-8d9a-ac1a53d9b25a", "AQAAAAEAACcQAAAAEOsAzFFVVZMEBP/d0BWxuHpppKXSXWvTFeZ7rHM+hqpCqWLeiheUwPShiUy4h5Yesw==", "fb46afaf-776f-46ad-aec2-a7a904f90484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04c6faa0-dbff-4eda-9bdd-39e9727cee40", "AQAAAAEAACcQAAAAEAhZlGNDvutHo304JnZ85BljNWGdtqFqy0pOQoq9EH7QGXJHVCIslQ4Og6EMoc2TQQ==", "7916480e-00f4-4a1d-aaf8-c48a9f508f7b" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=rhett+butler+cocktail&hl=en&sxsrf=ALiCzsbUCF-euUThMys6PTAiPP0xK4V37w%3A1668595185273&ei=8b10Y6ydEJqRxc8Pzo2z-As&oq=Rhett+Butler&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgBMgUIABCABDIKCAAQgAQQhwIQFDIFCAAQgAQyBQguEIAEMgUILhCABDIFCAAQgAQyBQgAEIAEMgUIABCABDILCC4QgAQQxwEQrwEyBQgAEIAESgQIQRgASgQIRhgAUABYAGCfF2gAcAF4AIABqQKIAakCkgEDMi0xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");
        }
    }
}
