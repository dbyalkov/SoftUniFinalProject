using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alcohols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alcohols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Glasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bartenders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bartenders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bartenders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Preparation = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    AlcoholId = table.Column<int>(type: "int", nullable: false),
                    BartenderId = table.Column<int>(type: "int", nullable: false),
                    GlassId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cocktails_Alcohols_AlcoholId",
                        column: x => x.AlcoholId,
                        principalTable: "Alcohols",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cocktails_Bartenders_BartenderId",
                        column: x => x.BartenderId,
                        principalTable: "Bartenders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cocktails_Glasses_GlassId",
                        column: x => x.GlassId,
                        principalTable: "Glasses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cocktails_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Alcohols",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Rum" },
                    { 2, false, "Brandy" },
                    { 3, false, "Gin" },
                    { 4, false, "Vodka" },
                    { 5, false, "Whiskey" },
                    { 6, false, "Wine and Champagne" },
                    { 7, false, "Tequila" },
                    { 8, false, "Other Alcoholic Beverages and Liqueurs" },
                    { 9, false, "Non-alcoholic Cocktails" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30342ffd-ffd8-4e66-9348-da6a2068856e", 0, "3f49d11c-cca1-4e75-a73e-e46931a28bf9", "doomar@abv.bg", false, false, null, "DOOMAR@ABV.BG", "D00M3R", "AQAAAAEAACcQAAAAEMpeSgGWtNqwzIMYukj7WRBFMNqTRjnUliM1XyC4FviM0nYqPdBAZk9dn78UKHoZMw==", null, false, "b87b4ada-d7bc-4ec4-b507-e1967a09aef4", false, "d00m3r" },
                    { "726719c4-8995-4426-9c00-1cb0831621d4", 0, "45a91f60-1c83-43dd-b291-30131bfd125b", "dbyalkov@abv.bg", false, false, null, "DBYALKOV@ABV.BG", "DBYALKOV", "AQAAAAEAACcQAAAAEFww/msVl6j1GfJliWu+eg8pB4PIjMex167v4bKeJW8WmKs9y34xV0wEUUdOebRzrg==", null, false, "350f5b81-5f79-4a7e-bee6-1e5f5fa2d100", false, "dbyalkov" }
                });

            migrationBuilder.InsertData(
                table: "Glasses",
                columns: new[] { "Id", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "https://www.google.com/search?q=Old+Fashioned+Glass&bih=937&biw=1920&hl=en&sxsrf=ALiCzsZksVXX7Jp6cFoRTLguZ9_rFgP01w%3A1668593623124&ei=17d0Y6CXB4XAxc8P5qePoA0&ved=0ahUKEwjg3rjRu7L7AhUFYPEDHebTA9QQ4dUDCA8&uact=5&oq=Old+Fashioned+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIECAAQQzIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYN0DaABwAXgAgAFniAFnkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Old Fashioned Glass" },
                    { 2, "https://www.google.com/search?q=Rocks+Glass&source=lmns&bih=937&biw=1920&hl=en&sa=X&ved=2ahUKEwjDgsTMu7L7AhUzhP0HHSXuDhEQ_AUoAHoECAEQAA", false, "Rocks Glass" },
                    { 3, "https://www.google.com/search?q=Cosmopolitan+Glass&hl=en&sxsrf=ALiCzsakKsEMVyRGZAk7S8Zs_2iykuym5A%3A1668593676149&ei=DLh0Y5XRCJSGxc8PxOKX2AY&ved=0ahUKEwiVh93qu7L7AhUUQ_EDHUTxBWsQ4dUDCA8&uact=5&oq=Cosmopolitan+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGDSAWgAcAF4AIABdIgBdJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Cosmopolitan Glass" },
                    { 4, "https://www.google.com/search?q=Highball+Glass&hl=en&sxsrf=ALiCzsZF3422_khQfxrWIHjSUWIgy0Ot0A%3A1668593702256&ei=Jrh0Y9aVD-2Sxc8P7-yOqA4&ved=0ahUKEwjWwJb3u7L7AhVtSfEDHW-2A-UQ4dUDCA8&uact=5&oq=Highball+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCRAjIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYLsBaABwAXgAgAGEAYgBhAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Highball Glass" },
                    { 5, "https://www.google.com/search?q=Collins+Glass&hl=en&sxsrf=ALiCzsacdfcPWofspFyJ4YW4-C9A0zbB_w%3A1668593720648&ei=OLh0Y6WKJ6yFxc8Phv296Aw&ved=0ahUKEwilhvn_u7L7AhWsQvEDHYZ-D80Q4dUDCA8&uact=5&oq=Collins+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYKkDaABwAXgAgAF5iAF5kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Collins Glass" },
                    { 6, "https://www.google.com/search?q=Zombie+Glass&hl=en&sxsrf=ALiCzsb9Onseh4wmGEC1WkKh5Vf-ZoEKuQ%3A1668593737947&ei=Sbh0Y4WvOfa_xc8PgKmUsA8&ved=0ahUKEwjF95iIvLL7AhX2X_EDHYAUBfYQ4dUDCA8&uact=5&oq=Zombie+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9gJoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Zombie Glass" },
                    { 7, "https://www.google.com/search?q=Weizen+Glass&hl=en&sxsrf=ALiCzsZSN98V4C5ier_raFN6DNaXJ3rDiw%3A1668593801173&ei=ibh0Y8qQCqyNxc8PobqUEA&ved=0ahUKEwiK-aumvLL7AhWsRvEDHSEdBQIQ4dUDCA8&uact=5&oq=Weizen+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIFCAAQkQIyBQgAEIAEMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIICAAQFhAeEAoyBggAEBYQHjIGCAAQFhAeSgQIQRgASgQIRhgAUABYAGCnBGgAcAF4AIABeYgBeZIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Weizen Glass" },
                    { 8, "https://www.google.com/search?q=Pilsner+Glass&hl=en&sxsrf=ALiCzsZO_TUrNQyiWYXd8YLg_RxexCkecg%3A1668593813987&ei=lbh0Y6PsO7erxc8P04mjgAc&ved=0ahUKEwjjirqsvLL7AhW3VfEDHdPECHAQ4dUDCA8&uact=5&oq=Pilsner+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCXAmgAcAB4AIABaIgBaJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Pilsner Glass" },
                    { 9, "https://www.google.com/search?q=Sling+Glass&hl=en&sxsrf=ALiCzsYiTS2gLkSIaOBNIKHtqcHCYSA8Dw%3A1668593841539&ei=sbh0Y7rBIJaPxc8Pk7SzuAU&ved=0ahUKEwj63cu5vLL7AhWWR_EDHRPaDFcQ4dUDCA8&uact=5&oq=Sling+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgcIABCABBAKMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeSgQIQRgASgQIRhgAUABYAGCUAWgAcAF4AIABhAGIAYQBkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Sling Glass" },
                    { 10, "https://www.google.com/search?q=Pint+Glass&hl=en&sxsrf=ALiCzsaKQCMC6IZ87woS9FzjcIdn3LgX3g%3A1668593853854&ei=vbh0Y7HVM8WSxc8P6pioqAc&ved=0ahUKEwjxp7u_vLL7AhVFSfEDHWoMCnUQ4dUDCA8&uact=5&oq=Pint+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgdGgAcAF4AIABAIgBAJIBAJgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Pint Glass" },
                    { 11, "https://www.google.com/search?q=Beer+Mug&hl=en&sxsrf=ALiCzsZXZ5ODI_ByrlwseAtObG8aAzXhAw%3A1668593867431&ei=y7h0Y6bxGZ6rxc8Pgoa-4Ao&ved=0ahUKEwjmgvjFvLL7AhWeVfEDHQKDD6wQ4dUDCA8&uact=5&oq=Beer+Mug&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnAFoAHABeACAAW-IAW-SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Beer Mug" },
                    { 12, "https://www.google.com/search?q=Irish+Coffee+Glass&hl=en&sxsrf=ALiCzsbHsswfqUjLnQcq4wB2AKgCa7fI0A%3A1668593882299&ei=2rh0Y4jfEe6Xxc8PyLGe4AU&ved=0ahUKEwiItIPNvLL7AhXuS_EDHciYB1wQ4dUDCA8&uact=5&oq=Irish+Coffee+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgiAdoAHAAeACAAXGIAXGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Irish Coffee Glass" },
                    { 13, "https://www.google.com/search?q=Red+Wine+Glass&hl=en&sxsrf=ALiCzsaTXw7Grstwjekn_pBLB9igMnC0eQ%3A1668594006964&ei=Vrl0Y8K-Or6Bxc8PwvOQMA&ved=0ahUKEwjCwbyIvbL7AhW-QPEDHcI5BAYQ4dUDCA8&uact=5&oq=Red+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgvAFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Red Wine Glass" },
                    { 14, "https://www.google.com/search?q=White+Wine+Glass&hl=en&sxsrf=ALiCzsb16F7oUzTE9Aac5Jxh1gYUPC1dAA%3A1668594033206&ei=cbl0Y-iNDKaNxc8PsYO6-Ac&ved=0ahUKEwioiv6UvbL7AhWmRvEDHbGBDn8Q4dUDCA8&uact=5&oq=White+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgkARoAHABeACAAWWIAWWSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "White Wine Glass" },
                    { 15, "https://www.google.com/search?q=Ballon+Wine+Glass&hl=en&sxsrf=ALiCzsbhDj1M1_XUz0bDO74I2ClBQnn36g%3A1668594047027&ei=f7l0Y5yhAdOFxc8P55G9oAQ&ved=0ahUKEwjc3MmbvbL7AhXTQvEDHedID0QQ4dUDCA8&uact=5&oq=Ballon+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIHCAAQgAQQCjIHCAAQgAQQCjIHCAAQgAQQCjIKCAAQFhAeEA8QCjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMggIABAWEB4QD0oECEEYAEoECEYYAFAAWABgxgFoAHABeACAAWqIAWqSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Ballon Wine Glass" },
                    { 16, "https://www.google.com/search?q=Wine+Tasting+Glass&hl=en&sxsrf=ALiCzsZFP7s2lnzXNi1TvQsnJuk2qHdkSg%3A1668594062150&ei=jrl0Y5DOCLqSxc8P0LC2iAQ&ved=0ahUKEwiQzeSivbL7AhU6SfEDHVCYDUEQ4dUDCA8&uact=5&oq=Wine+Tasting+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIAEMgUIABCABDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgzwFoAHABeACAAXKIAXKSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Wine Tasting Glass" },
                    { 17, "https://www.google.com/search?q=Sherry+Glass&hl=en&sxsrf=ALiCzsYBV8A6U6VwCHJlEyArnXD4QkyIUg%3A1668594074204&ei=mrl0Y_mDDLGFxc8PoZ2n-AY&ved=0ahUKEwj5uMSovbL7AhWxQvEDHaHOCW8Q4dUDCA8&uact=5&oq=Sherry+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyBQgAEIAEMggILhCABBDUAjIFCAAQgAQyBQgAEJECMgUIABCABDIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYL0FaABwAXgAgAGcAYgBnAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Sherry Glass" },
                    { 18, "https://www.google.com/search?q=Champagne+Flute&hl=en&sxsrf=ALiCzsb-4DbDXUgk-c2RAK3lWdL3iuf5ZA%3A1668594132088&ei=1Ll0Y-H1BImQxc8PwNuHmA4&ved=0ahUKEwjhr5HEvbL7AhUJSPEDHcDtAeMQ4dUDCA8&uact=5&oq=Champagne+Flute&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9wFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Champagne Flute" },
                    { 19, "https://www.google.com/search?q=Champagne+Coupe&hl=en&sxsrf=ALiCzsYSG73k8M9dBqZBv5NqfKRx4k0jOQ%3A1668594196658&ei=FLp0Y8XmJ8eMxc8Pjd6h0AE&ved=0ahUKEwjFwPbivbL7AhVHRvEDHQ1vCBoQ4dUDCA8&uact=5&oq=Champagne+Coupe&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9gFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Champagne Coupe" },
                    { 20, "https://www.google.com/search?q=Martini+Glass&hl=en&sxsrf=ALiCzsb7E6XWloUcn718PYvWpMoXoxeVcQ%3A1668594864123&ei=sLx0Y66IB5W9xc8PuOmuyAs&ved=0ahUKEwiuoJmhwLL7AhWVXvEDHbi0C7kQ4dUDCA8&uact=5&oq=Martini+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyBQgAEJECMgUIABCRAjIFCAAQkQIyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnwdoAHAAeACAAXmIAXmSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Martini Glass" },
                    { 21, "https://www.google.com/search?q=Margarita+Glass&hl=en&sxsrf=ALiCzsbD_7BOlu3uAGcVqV1qFsTP0wPiKA%3A1668594946758&ei=Ar10Y8vhLfC7xc8PleSNkAc&ved=0ahUKEwjL6szIwLL7AhXwXfEDHRVyA3IQ4dUDCA8&uact=5&oq=Margarita+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIICAAQgAQQywEyBAgAEEMyCggAEIAEEIcCEBQyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYL4CaABwAXgAgAFyiAFykgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Margarita Glass" },
                    { 22, "https://www.google.com/search?q=Goblet+Glass&hl=en&sxsrf=ALiCzsbAZ61wMs1ecdMo5PV88PgKq4aZUw%3A1668594974987&ei=Hr10Y5PwO6eTxc8Pl-SJmAE&ved=0ahUKEwiT94fWwLL7AhWnSfEDHRdyAhMQ4dUDCA8&uact=5&oq=Goblet+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGDhAWgAcAF4AIABa4gBa5IBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Goblet Glass" },
                    { 23, "https://www.google.com/search?q=Pokal+Glass&hl=en&sxsrf=ALiCzsa42LZ4PfpjzGaXj04rJXc-UOJahQ%3A1668594988929&ei=LL10Y6CbOKKTxc8Pn4Kx2A8&ved=0ahUKEwig4drcwLL7AhWiSfEDHR9BDPsQ4dUDCA8&uact=5&oq=Pokal+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCRAjIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYIMDaABwAXgAgAGJAYgBiQGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Pokal Glass" },
                    { 24, "https://www.google.com/search?q=Milkshake+Glass&hl=en&sxsrf=ALiCzsaDvvzr8oRf7bGgCxlwz_JVLUWTXw%3A1668595001452&ei=Ob10Y7KBG6KSxc8PntGS-Ao&ved=0ahUKEwjygdfiwLL7AhUiSfEDHZ6oBK8Q4dUDCA8&uact=5&oq=Milkshake+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIFCAAQgAQyBAgAEEMyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYPcBaABwAXgAgAFviAFvkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Milkshake Glass" },
                    { 25, "https://www.google.com/search?q=Hurricane+Glass&hl=en&sxsrf=ALiCzsZe3r32UGH96fybE7WwJCDhwaKuYg%3A1668595020212&ei=TL10Y4K9DPGtxc8P14-64Ag&ved=0ahUKEwiCk9DrwLL7AhXxVvEDHdeHDowQ4dUDCA8&uact=5&oq=Hurricane+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyCggAEIAEEIcCEBQyBQgAEJECMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnAFoAHABeACAAX6IAX6SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Hurricane Glass" },
                    { 26, "https://www.google.com/search?q=Poco+Grande+Glass&hl=en&sxsrf=ALiCzsZxE3RSuuxxBVsQsqQE1mY4my4eZw%3A1668595032646&ei=WL10Y5mLJ5iExc8Px9CdsAM&ved=0ahUKEwiZl8fxwLL7AhUYQvEDHUdoBzYQ4dUDCA8&uact=5&oq=Poco+Grande+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABEoECEEYAEoECEYYAFAAWABgqAFoAHABeACAAXyIAXySAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Poco Grande Glass" },
                    { 27, "https://www.google.com/search?q=Brandy+Snifter&hl=en&sxsrf=ALiCzsZNNDANMOfWDi63gU8kEaLt6-aaxQ%3A1668595044186&ei=ZL10Y4SEC8CBxc8P-P6YaA&ved=0ahUKEwiExof3wLL7AhXAQPEDHXg_Bg0Q4dUDCA8&uact=5&oq=Brandy+Snifter&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCBCGgAcAF4AIABd4gBd5IBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Brandy Snifter" },
                    { 28, "https://www.google.com/search?q=Wobble+Cognac+Glass&hl=en&sxsrf=ALiCzsbslu4l-7YPDgEjnhxyUb01ghWZKQ%3A1668595057314&ei=cb10Y7TbEsi_xc8PxZ6IyAc&ved=0ahUKEwj016j9wLL7AhXIX_EDHUUPAnkQ4dUDCA8&uact=5&oq=Wobble+Cognac+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIYDMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYLEBaABwAXgAgAF5iAF5kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Wobble Cognac Glass" },
                    { 29, "https://www.google.com/search?q=Tulip+Whisky+Glass&hl=en&sxsrf=ALiCzsZqjgEcBXhP0F74w6ukhSdjlan1yg%3A1668595068685&ei=fL10Y7mUKeKExc8P3oOtsAE&ved=0ahUKEwi5wt6CwbL7AhViQvEDHd5BCxYQ4dUDCA8&uact=5&oq=Tulip+Whisky+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABghgFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Tulip Whisky Glass" },
                    { 30, "https://www.google.com/search?q=Tulip+Glass&hl=en&sxsrf=ALiCzsY5AD5KJ64NlBoMbrgXc9nEVngljw%3A1668595084467&ei=jL10Y5iJHMaOxc8P16-VWA&ved=0ahUKEwiY_6GKwbL7AhVGR_EDHddXBQsQ4dUDCA8&uact=5&oq=Tulip+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYIgBaABwAXgAgAFyiAFykgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false, "Tulip Glass" },
                    { 31, "https://www.google.com/search?q=Grappa+Glass&hl=en&sxsrf=ALiCzsZEGOAmdlUCbrPSfHv79TXEN4XHBg%3A1668595098940&ei=mr10Y7b5OPiMxc8PoYedsA4&ved=0ahUKEwi2rpWRwbL7AhV4RvEDHaFDB-YQ4dUDCA8&uact=5&oq=Grappa+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCCA2gAcAF4AIABeIgBeJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Grappa Glass" }
                });

            migrationBuilder.InsertData(
                table: "Glasses",
                columns: new[] { "Id", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 32, "https://www.google.com/search?q=Pousse+Cafe+Glass&hl=en&sxsrf=ALiCzsayNpwTrWErAORtXInTKGmPiEmgcw%3A1668595113445&ei=qb10Y5rbGv66xc8Pu4Gz-As&ved=0ahUKEwja04qYwbL7AhV-XfEDHbvADL8Q4dUDCA8&uact=5&oq=Pousse+Cafe+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIFCAAQhgMyBQgAEIYDMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYNsCaABwAXgAgAGAAYgBgAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Pousse Cafe Glass" },
                    { 33, "https://www.google.com/search?q=Cordial+Glass&hl=en&sxsrf=ALiCzsYgPJPMIWXBzryN9c8CkrFt_UFWoQ%3A1668595125086&ei=tb10Y5rnBPWBxc8PjcGv-Ag&ved=0ahUKEwjaldGdwbL7AhX1QPEDHY3gC48Q4dUDCA8&uact=5&oq=Cordial+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgfmgAcAB4AIABAIgBAJIBAJgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false, "Cordial Glass" },
                    { 34, "https://www.google.com/search?q=Absinthe+Glass&hl=en&sxsrf=ALiCzsb1qF2QVishHqOISrTAq8krWmY2fA%3A1668595137676&ei=wb10Y7z0KN2Uxc8P8fW1sAg&ved=0ahUKEwj82NGjwbL7AhVdSvEDHfF6DYYQ4dUDCA8&uact=5&oq=Absinthe+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgQIABBDMgUIABCABEoECEEYAEoECEYYAFAAWABgjgFoAHABeACAAXOIAXOSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Absinthe Glass" },
                    { 35, "https://www.google.com/search?q=Vodka+Glass&hl=en&sxsrf=ALiCzsYxVsK6UlZJvje9KDHv5qfRj3SdKg%3A1668595147610&ei=y710Y6DfJJG-xc8PxZGI2AY&ved=0ahUKEwjg8K-owbL7AhURX_EDHcUIAmsQ4dUDCA8&uact=5&oq=Vodka+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgtANoAHABeACAAXqIAXqSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Vodka Glass" },
                    { 36, "https://www.google.com/search?q=Shooter+Glass&hl=en&sxsrf=ALiCzsYCiHwVGHnonR3h9IiOti6KcMT2oA%3A1668595161113&ei=2b10Y5S_BoCPxc8Puem40Ak&ved=0ahUKEwjUj-iuwbL7AhWAR_EDHbk0DpoQ4dUDCA8&uact=5&oq=Shooter+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIHCAAQgAQQCjIFCAAQgAQyBwgAEIAEEAoyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgsQFoAHABeACAAXuIAXuSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Shooter Glass" },
                    { 37, "https://www.google.com/search?q=Shot+Glass&hl=en&sxsrf=ALiCzsaicIYZvf42TLqqcQM_w1awx-68Hg%3A1668595172668&ei=5L10Y4mvKMiMxc8P7aKomAc&ved=0ahUKEwiJsam0wbL7AhVIRvEDHW0RCnMQ4dUDCA8&uact=5&oq=Shot+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIECAAQQzIECAAQQzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBAgAEEMyBQgAEIAEMgQIABBDMgUIABCABEoECEEYAEoECEYYAFAAWABgzwFoAHABeACAAW2IAW2SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp", false, "Shot Glass" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImageUrl", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "https://www.google.com/search?q=Cocktail+Gauguin&hl=en&sxsrf=ALiCzsYZijqseouEFjzKEYTw-66_8uzpsA%3A1668594209334&ei=Ibp0Y5P1E_GTxc8PpdmT8AI&ved=0ahUKEwjTifzovbL7AhXxSfEDHaXsBC4Q4dUDCA8&uact=5&oq=Cocktail+Gauguin&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIGCAAQFhAeOgoIABBHENYEELADOgcIABCwAxBDOg0IABDkAhDWBBCwAxgBOhIILhDHARDRAxDIAxCwAxBDGAI6FQguEMcBENEDENQCEMgDELADEEMYAjoECAAQQzoKCC4QxwEQ0QMQQzoQCC4QgAQQhwIQxwEQ0QMQFDoFCAAQgAQ6CwguEIAEEMcBENEDOgcILhDUAhBDOggILhCABBDUAjoKCC4Q1AIQgAQQQzoICAAQgAQQyQM6DgguEIAEEMcBEK8BEMsBSgQIQRgASgQIRhgBUNIJWNQmYKUuaARwAXgAgAGNAYgBmQmSAQQwLjEwmAEAoAEBoAECyAERwAEB2gEGCAEQARgJ2gEGCAIQARgI&sclient=gws-wiz-serp", false },
                    { 2, "https://www.google.com/search?q=sex+on+the+beach+cocktail&hl=en&sxsrf=ALiCzsbVoUJDMmVhnd712I2_OEi4zn8HKQ%3A1668597389724&ei=jcZ0Y8DaK7CWxc8P7pS3uAs&gs_ssp=eJzj4tLP1TcwKsqotCg2YHRg8JIsTq1QyM9TKMlIVUhKTUzOUEjOT84uSczMAQAB0Q0_&oq=Sex+on+the+Beach+&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgAMgcILhCABBBDMgQIABBDMggILhCABBDLATIICAAQgAQQywEyBQgAEIAEMgQIABBDMgQIABBDMgUIABCABDIFCAAQgAQyCggAEIAEEIcCEBRKBAhBGABKBAhGGABQAFi5A2DBIGgAcAF4AIABnQGIAY4CkgEDMC4ymAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false },
                    { 3, "https://www.google.com/search?q=rhett+butler+cocktail&hl=en&sxsrf=ALiCzsbUCF-euUThMys6PTAiPP0xK4V37w%3A1668595185273&ei=8b10Y6ydEJqRxc8Pzo2z-As&oq=Rhett+Butler&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgBMgUIABCABDIKCAAQgAQQhwIQFDIFCAAQgAQyBQguEIAEMgUILhCABDIFCAAQgAQyBQgAEIAEMgUIABCABDILCC4QgAQQxwEQrwEyBQgAEIAESgQIQRgASgQIRhgAUABYAGCfF2gAcAF4AIABqQKIAakCkgEDMi0xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp", false },
                    { 4, "https://www.google.com/search?q=Cheshire+Cat+Cocktail&sxsrf=ALiCzsYnvGR_m4i19I70GL1_6ctyPC0kCg%3A1668601527470&ei=t9Z0Y62oHP-Pxc8PoaufkAM&ved=0ahUKEwjt38OK2bL7AhX_R_EDHaHVBzIQ4dUDCA8&uact=5&oq=Cheshire+Cat+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMggIABAWEB4QDzIFCAAQhgMyBQgAEIYDMgUIABCGAzIFCAAQhgMyBQgAEIYDOgoIABBHENYEELADOgcIABCwAxBDOg0IABDkAhDWBBCwAxgBOgwILhDIAxCwAxBDGAI6DwguENQCEMgDELADEEMYAjoECAAQQzoICAAQgAQQywE6BQghEKABSgQIQRgASgQIRhgBUJcBWN8qYN0uaANwAXgAgAGTAYgB8gmSAQQxLjEwmAEAoAEByAETwAEB2gEGCAEQARgJ2gEGCAIQARgI&sclient=gws-wiz-serp", false },
                    { 5, "https://www.google.com/search?q=Mexicana+Cocktail&sxsrf=ALiCzsbqImQPN1VjWrRYrgZM5Fnv2oYZ3Q%3A1668601536059&ei=wNZ0Y5WXA9uIxc8P_c2z4AY&ved=0ahUKEwiV98-O2bL7AhVbRPEDHf3mDGwQ4dUDCA8&uact=5&oq=Mexicana+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyCAgAEIAEEMsBMggIABAWEB4QCjIGCAAQFhAeMgYIABAWEB4yCAgAEBYQHhAKMgYIABAWEB4yCggAEBYQHhAPEAoyCAgAEBYQHhAKMgYIABAWEB46BQguEIAEOgUIIRCgAToKCAAQgAQQhwIQFDoHCAAQgAQQCjoICAAQFhAeEA9KBAhBGABKBAhGGABQAFioNWCrN2gCcAF4AIABigGIAfgJkgEEMC4xMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false },
                    { 6, "https://www.google.com/search?q=Slippery+Nipple+Cocktail&sxsrf=ALiCzsZ4y_0nwTU0wFWwU8KO1G0xUdBsSA%3A1668601931172&ei=S9h0Y9b_CYqqxc8P68qFyA4&ved=0ahUKEwiW0YPL2rL7AhUKVfEDHWtlAekQ4dUDCA8&uact=5&oq=Slippery+Nipple+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCC4QgAQQhwIQFDIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIFCAAQhgMyBQgAEIYDOgYIABAHEB46BQguEIAEOgYIABAIEB5KBAhBGABKBAhGGABQAFgAYP4haABwAXgAgAGjAogBpgOSAQUwLjEuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp", false },
                    { 7, "https://www.google.com/search?q=Bitter+Sweet+Cocktail&sxsrf=ALiCzsYtnnGfQTc9sgKc8-ouqUjsQ4hILg%3A1668602388689&ei=FNp0Y7PUKc-Xxc8P0MOomA4&ved=0ahUKEwizrpil3LL7AhXPS_EDHdAhCuMQ4dUDCA8&uact=5&oq=Bitter+Sweet+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIGCAAQBxAeMgUIABCABDIFCAAQgAQyCAgAEAgQHhAKMgYIABAIEB4yBQgAEIYDMgUIABCGAzoLCAAQBxAeELADEAo6BwgAELADEEM6CAgAEIAEELADOgsIABCABBCwAxDLAToJCAAQCBAeELADOgwILhDIAxCwAxBDGAE6DwguENQCEMgDELADEEMYAUoECEEYAUoECEYYAVDHggtYx4ILYJ6MC2gBcAB4AIABfIgBfJIBAzAuMZgBAKABAqABAcgBEsABAdoBBggBEAEYCA&sclient=gws-wiz-serp", false }
                });

            migrationBuilder.InsertData(
                table: "Bartenders",
                columns: new[] { "Id", "Age", "FirstName", "IsDeleted", "LastName", "UserId" },
                values: new object[] { 1, 28, "Dimitar", false, "Byalkov", "726719c4-8995-4426-9c00-1cb0831621d4" });

            migrationBuilder.InsertData(
                table: "Cocktails",
                columns: new[] { "Id", "AlcoholId", "BartenderId", "GlassId", "ImageId", "IsDeleted", "Name", "Preparation", "Recipe" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, false, "Gauguin", "Place the crushed ice, rum, syrup and lemon juice in a blender and blend on low speed for 15 seconds. Strain the resulting mixture into an old fashioned glass and garnish with the cocktail cherry.", "3 parts crushed ice\r\n2 parts white rum\r\n2 tsp passion fruit syrup\r\n2 tsp lemon juice\r\n1 tsp lime juice\r\n1 cocktail cherry for decoration" },
                    { 2, 2, 1, 20, null, false, "Toulon", "Place the ice cubes in a serving glass and pour the vermouth, liqueur and brandy over them and stir vigorously. Strain the resulting mixture into a chilled cocktail glass and garnish with the orange peel.", "4-5 ice cubes\r\n1 part dry vermouth\r\n1 part Benedictine liqueur\r\n3 parts brandy\r\na strip of orange peel for decoration" },
                    { 3, 3, 1, 4, null, false, "Sweet Sixteen", "Place half the ice cubes in a shaker, pour over the gin, lime juice, grenadine and sugar syrup and shake until frosty. Put the remaining ice in a tall glass, strain the resulting mixture over the ice and top up the glass with lemon bitters. Finally, garnish with the lemon peel.", "6-8 ice cubes\r\n2 parts gin\r\njuice of half a green lemon\r\n2 dashes of grenadine\r\n1 tsp sugar syrup\r\nlemon bitters\r\nlemon zest for garnish" },
                    { 4, 4, 1, 4, 2, false, "Sex on the Beach", "Add a few ice cubes to the shaker along with the vodka, schnapps, cranberry juice, orange juice and pineapple juice (if desired) and shake well. Put 3-4 ice cubes in a tall glass and pour the resulting mixture over them. Finally, garnish the drink with the green lemon slices and the orange slices and serve the cocktail with a straw.", "ice cubes\r\n1 part vodka\r\n1 part peach schnapps\r\n1 part cranberry juice\r\n1 part orange juice\r\n1 part pineapple juice (optional)\r\norange slices for decoration\r\nslices of green lemon for decoration" },
                    { 5, 5, 1, 1, 3, false, "Rhett Butler", "Place the ice cubes in a shaker along with the bourbon, cranberry juice, sugar syrup and lime juice and shake well. Strain the resulting mixture into an old fashioned glass filled with ice cubes, garnish with a lemon wedge and serve with a short straw.", "4-5 ice cubes and extra for serving\r\n2 parts bourbon whiskey\r\n4 parts cranberry juice\r\n2 tbsp sugar syrup\r\n1 tbsp fresh lemon juice\r\na slice of green lemon for garnish" },
                    { 6, 6, 1, 18, 4, false, "Cheshire Cat", "Put the ice cubes in a serving glass, pour over them the brandy, vermouth and orange juice and stir until a homogeneous mixture is obtained. Strain the resulting mixture into a tall champagne glass and top up with champagne. Squeeze the essential oil from one orange peel into the drink and garnish with a spiral orange peel.", "4-5 ice cubes\r\n1 part brandy\r\n1 part sweet vermouth\r\nchampagne\r\norange peels for garnish" },
                    { 7, 7, 1, 4, 5, false, "Mexicana", "Place half of the ice cubes in a shaker along with the tequila, raspberry liqueur and fruit juices and shake vigorously for about 10 seconds. Put the remaining ice cubes in a tall glass and pour the resulting mixture over them. Finally, garnish the drink with the pineapple and lemon slice.", "8-10 ice cubes\r\n1 1/4 parts tequila\r\n3/4 part raspberry liqueur\r\n3/4 part fresh lemon juice\r\n3 1/2 parts pineapple juice\r\npineapple slice for garnish\r\nlemon slice for garnish" },
                    { 8, 8, 1, 37, 6, false, "Slippery Nipple", "Pour the Sambuca liqueur into a tequila (shot) glass, then using the back of a bar spoon, slowly pour the Irish liqueur over the Sambuca so that the two liqueurs do not mix.", "1 part \"Sambuca\" liqueur\r\n1/2 part Baileys Irish Liqueur" },
                    { 9, 9, 1, 20, 7, false, "Bitter Sweet", "Put the crushed ice in a shaker, pour on it 2 tbsp of the sparkling water and bitters, add the mint leaves and mix until frost forms. Pour the resulting mixture into a chilled glass, fill it with sparkling water and decorate the drink with slices of green or yellow lemon.", "crushed ice\r\n150 ml sparkling water\r\n2 dashes \"Angostura\" bitters\r\n6-8 mint leaves\r\ngreen or yellow lemon circles for decoration" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bartenders_UserId",
                table: "Bartenders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_AlcoholId",
                table: "Cocktails",
                column: "AlcoholId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_BartenderId",
                table: "Cocktails",
                column: "BartenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_GlassId",
                table: "Cocktails",
                column: "GlassId");

            migrationBuilder.CreateIndex(
                name: "IX_Cocktails_ImageId",
                table: "Cocktails",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cocktails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Alcohols");

            migrationBuilder.DropTable(
                name: "Bartenders");

            migrationBuilder.DropTable(
                name: "Glasses");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
