using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class ChangeInRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_Alcohols_AlcoholId",
                table: "Cocktails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3941883f-74aa-456e-9b56-447651d37e1d", "AQAAAAEAACcQAAAAEMPIQ60y8yG1TcsrAnz08wqsab1lB930mFBIMlWY5b+S5apDRPMkvFnTzeaDi5GiTA==", "871220d0-9e4b-4b60-95cc-64d8750970e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6140d0e-4a75-4e7b-b0ac-7f31b181564e", "AQAAAAEAACcQAAAAEC3cQQmnCrd7WyL6ShhOWwQeUC7tQq//XetzYTb9xSv5zd+B1hBLSNG7K4wcgd/Z0Q==", "e5f37cec-78a1-42c2-b7b8-f19d58a9a03d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_Alcohols_AlcoholId",
                table: "Cocktails",
                column: "AlcoholId",
                principalTable: "Alcohols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cocktails_Alcohols_AlcoholId",
                table: "Cocktails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30342ffd-ffd8-4e66-9348-da6a2068856e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad90eea-f6e6-4d2d-b2ec-7f6cb056749b", "AQAAAAEAACcQAAAAECJb8N+uEyRXhJ51sgVQKza9uM0vOMr9YIHu75nX5tpj0zNwEMW8oDhtXrBhKk+PPg==", "567be458-be98-4c03-bc86-4cdb6fb5f14f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "726719c4-8995-4426-9c00-1cb0831621d4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0fc2768-bdb7-40b6-8d19-4604f97f5839", "AQAAAAEAACcQAAAAEBKx8gzJzZTFJvKz15p2wfXIfac+bSorNZRESZi29p4y8Q5lsIVxYa5bERczkl61Gg==", "11613833-e39f-48dc-b919-32a7b7beb483" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cocktails_Alcohols_AlcoholId",
                table: "Cocktails",
                column: "AlcoholId",
                principalTable: "Alcohols",
                principalColumn: "Id");
        }
    }
}
