using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class AnotherOneChangeInRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailsImages");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "6866a638-9b97-4d7b-966a-9a9a9a8d9331", "AQAAAAEAACcQAAAAENI+yP245FuroPoeMZEvNwfuBB82sTTpOL5AP2+UScUeevHW5iYbaypNAKmD3kdyxw==", "49152321-1b2a-471c-9c02-b8a823a4baca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bea75f7e-52e1-493d-a20c-791464b68713", "AQAAAAEAACcQAAAAENYqyMPJCT4Qjw6cljsYaXcfuq6ly1mIcy0yv9X8FT3rQ5JzssZ3HjMbpIIL2QljGw==", "770b12e9-b6bc-4115-891a-e6ffbf5f5e86" });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailsImages_ImageId",
                table: "CocktailsImages",
                column: "ImageId");
        }
    }
}
