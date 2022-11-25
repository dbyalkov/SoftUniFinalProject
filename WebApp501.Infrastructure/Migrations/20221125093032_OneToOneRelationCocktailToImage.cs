using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class OneToOneRelationCocktailToImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailsImages");

            migrationBuilder.AddColumn<int>(
                name: "CocktailId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Bartenders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Alcohols",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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
                keyValue: 1,
                column: "CocktailId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CocktailId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CocktailId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CocktailId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CocktailId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CocktailId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CocktailId",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_Images_CocktailId",
                table: "Images",
                column: "CocktailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cocktails_CocktailId",
                table: "Images",
                column: "CocktailId",
                principalTable: "Cocktails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cocktails_CocktailId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CocktailId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CocktailId",
                table: "Images");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Bartenders",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Alcohols",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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

            migrationBuilder.CreateIndex(
                name: "IX_CocktailsImages_ImageId",
                table: "CocktailsImages",
                column: "ImageId");
        }
    }
}
