using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class AnotherChangeInRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_Images_ImageId",
                table: "Cocktails");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cocktails_CocktailId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CocktailId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Cocktails_ImageId",
                table: "Cocktails");

            migrationBuilder.DropColumn(
                name: "CocktailId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Cocktails");

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
                values: new object[] { "6866a638-9b97-4d7b-966a-9a9a9a8d9331", "AQAAAAEAACcQAAAAENI+yP245FuroPoeMZEvNwfuBB82sTTpOL5AP2+UScUeevHW5iYbaypNAKmD3kdyxw==", "49152321-1b2a-471c-9c02-b8a823a4baca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bea75f7e-52e1-493d-a20c-791464b68713", "AQAAAAEAACcQAAAAENYqyMPJCT4Qjw6cljsYaXcfuq6ly1mIcy0yv9X8FT3rQ5JzssZ3HjMbpIIL2QljGw==", "770b12e9-b6bc-4115-891a-e6ffbf5f5e86" });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailImage_ImagesId",
                table: "CocktailImage",
                column: "ImagesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailImage");

            migrationBuilder.AddColumn<int>(
                name: "CocktailId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Cocktails",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba69b862-5e65-424c-9635-9e92d1b57e22", "AQAAAAEAACcQAAAAEKQczDUzYUG8AZhJ7KDfY0VprmuzD0x36gMHWI+G1Zkwpiv6J6WxXH5alL55KyGWAg==", "9614dd69-c8bd-4192-a3b0-342635726dd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c03c60e-5dbb-487f-90cc-76bc3de756f4", "AQAAAAEAACcQAAAAEOcPYurcNchAsSYnLnhDNYkPC3HFGEC6qMj9r1kUuxsnwvt/d1C1LOlJXMVPJmNgug==", "044ccc44-f879-466e-a362-e17b46e7bc67" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CocktailId",
                table: "Images",
                column: "CocktailId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_ImageId",
                table: "Cocktails",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_Images_ImageId",
                table: "Cocktails",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cocktails_CocktailId",
                table: "Images",
                column: "CocktailId",
                principalTable: "Cocktails",
                principalColumn: "Id");
        }
    }
}
