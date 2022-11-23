using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class YetAnotherChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailImage");

            migrationBuilder.CreateTable(
                name: "CocktailsImages",
                columns: table => new
                {
                    CocktailId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailsImages", x => new { x.CocktailId, x.ImageId });
                    table.ForeignKey(
                        name: "FK_CocktailsImages_Cocktails_CocktailId",
                        column: x => x.CocktailId,
                        principalTable: "Cocktails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailsImages_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CocktailsImages_ImageId",
                table: "CocktailsImages",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailsImages");

            migrationBuilder.CreateTable(
                name: "CocktailImage",
                columns: table => new
                {
                    CocktailsId = table.Column<int>(type: "int", nullable: false),
                    ImagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailImage", x => new { x.CocktailsId, x.ImagesId });
                    table.ForeignKey(
                        name: "FK_CocktailImage_Cocktails_CocktailsId",
                        column: x => x.CocktailsId,
                        principalTable: "Cocktails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailImage_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65948ef-f9e8-4066-a246-8625da62bbdd", "AQAAAAEAACcQAAAAEEMjG+eRQ84YgVdCrNyxnTRgwhyXcbIyG3UpRQ2OBbOvr38eC4ZaqAJN7TVtTpbxHw==", "d1a7987e-1596-4ed5-8078-455bab8ba74c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d07fc87-a27e-44c2-8ada-bf29e34b8c2a", "AQAAAAEAACcQAAAAEOK9n8iRbXbXO7hLXdmEB01oBqiSAqp4YjZCr/bGi8g1lKxR8UKUUcJGRL46EGtduQ==", "e0abcf47-d160-4a8e-a92e-2231797291b9" });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailImage_ImagesId",
                table: "CocktailImage",
                column: "ImagesId");
        }
    }
}
