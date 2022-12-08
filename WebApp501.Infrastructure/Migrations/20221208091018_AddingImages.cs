using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp501.Infrastructure.Migrations
{
    public partial class AddingImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/51ErdYtGOAL.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.cocktailkingdom.com/media/catalog/product/cache/1/image/364x/040ec09b1e35df139433887a97daa66f/g/l/gla_ckrksyarai_6101_clr_web1_1.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://johnlewis.scene7.com/is/image/JohnLewis/233596730?$rsp-pdp-port-640$");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/31ncXtqfK7L._SL500_.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/31vvQmBDhdL.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://cdn.shoplightspeed.com/shops/606142/files/5865756/1500x4000x3/fizz-zombie-glass-135-oz.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://hosteleria.araven.com/sites/default/files/styles/producto/public/91641_copa_weiser_cerveza.jpg?itok=9N2yaZRa");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.ikea.com/my/en/images/products/oanvaend-beer-glass-clear-glass__0713254_pe729369_s5.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://cdn.shopify.com/s/files/1/0520/0943/5294/products/UB15.jpg?v=1616053755");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://cdnimg.webstaurantstore.com/images/products/large/41072/2310339.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.ikea.com/us/en/images/products/mjoed-beer-mug-clear-glass__0525765_pe644916_s5.jpg?f=s");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.sbb-bg.com/image/cache/catalog/images/Uniglass/1076_44856-550x700w.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/51pEW1I+FJL._SY879_.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://www.ikea.com/gb/en/images/products/dyrgrip-white-wine-glass-clear-glass__0712421_pe728840_s5.jpg?f=s");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://www.intornoalvino.com/731-large_default/red-wine-glasses-ballon-vineas.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://media.nisbets.com/asset/core/prodimage/large_new/gf738_g817-1707.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/61DcUapHwjL.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://5.imimg.com/data5/CU/RU/SE/SELLER-25193472/ocean-champagne-flute-glass-500x500.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.ikea.com/gb/en/images/products/storhet-champagne-coupe-clear-glass__0713258_pe729368_s5.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://www.ikea.com/ca/en/images/products/storsint-martini-glass-clear-glass__0800268_pe767839_s5.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://www.ikea.com/om/en/images/products/festlighet-margarita-glass__0712417_pe728836_s5.jpg?f=s");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://www.webstaurantstore.com/images/products/large/88017/1877520.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "http://www.ajmara.pl/upd_cnt/attch/img_pro/colibri_pokal_do_piwa.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://www.drinkstuff.com/productimg/47978_large.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://cdnimg.webstaurantstore.com/images/products/large/232957/2396272.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/41a1riW3YxL.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1571017071-31p5xeITE9L.jpg?crop=1xw:0.938xh");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "http://1.bp.blogspot.com/-ZWq1ngNmIQM/VGZVL090-CI/AAAAAAAAbtU/L1lk0iv8_kQ/s1600/Cognac-Delamain-with-Baccarat-Le-Voyage-Decanter-Bottle-2.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://boomingglassware.com/wp-content/uploads/2019/08/BMWky-02%EF%BC%881%EF%BC%89.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://glassmania.com/media/catalog/product/cache/6b9c9ff9456b96523530d9a877110061/n/v/nvr42bsen_1.png");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://cdn.shopify.com/s/files/1/0615/8575/2295/products/Plain_-_Vintage_Grappa_Glass_-_66110_-_1052488_v1_1800x1800_56febef2-76df-4c4a-9a15-33d885d9944d_1500x.jpg?v=1640309929");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKc6d02gFVbrW57FF9OVXAiqUcAb8YkgPhGMWGpxaCGQ&s");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://secure.img1-cg.wfcdn.com/im/54073283/resize-h600-w600%5Ecompr-r85/1612/16121821/Cordial+Glasses.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://assets.manufactum.de/p/020/020056/20056_01.jpg/absinthe-glass-la-rochere.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/vodka-glasses-1638468889.jpg?crop=0.502xw:1.00xh;0.250xw,0&resize=640:*");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://m.media-amazon.com/images/I/51MpZbNhM-L.jpg");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://media.istockphoto.com/id/178410979/photo/empty-glass.jpg?s=612x612&w=0&k=20&c=BcS4A2H_nxwc4uTWOHb2vRjLs_DgIOWk2aL4tKDzHv4=");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://cdn.diffords.com/contrib/stock-images/2018/05/5af304cee08a4.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://copykat.com/wp-content/uploads/2022/05/Sex-on-the-Beach-Drink-Pin-9.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://media-cdn.tripadvisor.com/media/photo-m/1280/13/88/99/f9/cheshire-cat-cocktail.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://vinepair.com/wp-content/uploads/2017/09/Mexicano_Card.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://cocktailsandshots.com/wp-content/uploads/2018/06/Slippery-nipple-shot-recipe-with-ingredients-sambuca-baileys.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://cdn.diffords.com/contrib/stock-images/2016/10/53/201600e4ec5eb6ed8167e09d75ed35abe569.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Old+Fashioned+Glass&bih=937&biw=1920&hl=en&sxsrf=ALiCzsZksVXX7Jp6cFoRTLguZ9_rFgP01w%3A1668593623124&ei=17d0Y6CXB4XAxc8P5qePoA0&ved=0ahUKEwjg3rjRu7L7AhUFYPEDHebTA9QQ4dUDCA8&uact=5&oq=Old+Fashioned+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIECAAQQzIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYN0DaABwAXgAgAFniAFnkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Rocks+Glass&source=lmns&bih=937&biw=1920&hl=en&sa=X&ved=2ahUKEwjDgsTMu7L7AhUzhP0HHSXuDhEQ_AUoAHoECAEQAA");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Cosmopolitan+Glass&hl=en&sxsrf=ALiCzsakKsEMVyRGZAk7S8Zs_2iykuym5A%3A1668593676149&ei=DLh0Y5XRCJSGxc8PxOKX2AY&ved=0ahUKEwiVh93qu7L7AhUUQ_EDHUTxBWsQ4dUDCA8&uact=5&oq=Cosmopolitan+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGDSAWgAcAF4AIABdIgBdJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Highball+Glass&hl=en&sxsrf=ALiCzsZF3422_khQfxrWIHjSUWIgy0Ot0A%3A1668593702256&ei=Jrh0Y9aVD-2Sxc8P7-yOqA4&ved=0ahUKEwjWwJb3u7L7AhVtSfEDHW-2A-UQ4dUDCA8&uact=5&oq=Highball+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCRAjIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYLsBaABwAXgAgAGEAYgBhAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Collins+Glass&hl=en&sxsrf=ALiCzsacdfcPWofspFyJ4YW4-C9A0zbB_w%3A1668593720648&ei=OLh0Y6WKJ6yFxc8Phv296Aw&ved=0ahUKEwilhvn_u7L7AhWsQvEDHYZ-D80Q4dUDCA8&uact=5&oq=Collins+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYKkDaABwAXgAgAF5iAF5kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Zombie+Glass&hl=en&sxsrf=ALiCzsb9Onseh4wmGEC1WkKh5Vf-ZoEKuQ%3A1668593737947&ei=Sbh0Y4WvOfa_xc8PgKmUsA8&ved=0ahUKEwjF95iIvLL7AhX2X_EDHYAUBfYQ4dUDCA8&uact=5&oq=Zombie+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9gJoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Weizen+Glass&hl=en&sxsrf=ALiCzsZSN98V4C5ier_raFN6DNaXJ3rDiw%3A1668593801173&ei=ibh0Y8qQCqyNxc8PobqUEA&ved=0ahUKEwiK-aumvLL7AhWsRvEDHSEdBQIQ4dUDCA8&uact=5&oq=Weizen+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIFCAAQkQIyBQgAEIAEMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIICAAQFhAeEAoyBggAEBYQHjIGCAAQFhAeSgQIQRgASgQIRhgAUABYAGCnBGgAcAF4AIABeYgBeZIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Pilsner+Glass&hl=en&sxsrf=ALiCzsZO_TUrNQyiWYXd8YLg_RxexCkecg%3A1668593813987&ei=lbh0Y6PsO7erxc8P04mjgAc&ved=0ahUKEwjjirqsvLL7AhW3VfEDHdPECHAQ4dUDCA8&uact=5&oq=Pilsner+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCXAmgAcAB4AIABaIgBaJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Sling+Glass&hl=en&sxsrf=ALiCzsYiTS2gLkSIaOBNIKHtqcHCYSA8Dw%3A1668593841539&ei=sbh0Y7rBIJaPxc8Pk7SzuAU&ved=0ahUKEwj63cu5vLL7AhWWR_EDHRPaDFcQ4dUDCA8&uact=5&oq=Sling+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgcIABCABBAKMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeSgQIQRgASgQIRhgAUABYAGCUAWgAcAF4AIABhAGIAYQBkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Pint+Glass&hl=en&sxsrf=ALiCzsaKQCMC6IZ87woS9FzjcIdn3LgX3g%3A1668593853854&ei=vbh0Y7HVM8WSxc8P6pioqAc&ved=0ahUKEwjxp7u_vLL7AhVFSfEDHWoMCnUQ4dUDCA8&uact=5&oq=Pint+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgdGgAcAF4AIABAIgBAJIBAJgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Beer+Mug&hl=en&sxsrf=ALiCzsZXZ5ODI_ByrlwseAtObG8aAzXhAw%3A1668593867431&ei=y7h0Y6bxGZ6rxc8Pgoa-4Ao&ved=0ahUKEwjmgvjFvLL7AhWeVfEDHQKDD6wQ4dUDCA8&uact=5&oq=Beer+Mug&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnAFoAHABeACAAW-IAW-SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Irish+Coffee+Glass&hl=en&sxsrf=ALiCzsbHsswfqUjLnQcq4wB2AKgCa7fI0A%3A1668593882299&ei=2rh0Y4jfEe6Xxc8PyLGe4AU&ved=0ahUKEwiItIPNvLL7AhXuS_EDHciYB1wQ4dUDCA8&uact=5&oq=Irish+Coffee+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgiAdoAHAAeACAAXGIAXGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Red+Wine+Glass&hl=en&sxsrf=ALiCzsaTXw7Grstwjekn_pBLB9igMnC0eQ%3A1668594006964&ei=Vrl0Y8K-Or6Bxc8PwvOQMA&ved=0ahUKEwjCwbyIvbL7AhW-QPEDHcI5BAYQ4dUDCA8&uact=5&oq=Red+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgvAFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=White+Wine+Glass&hl=en&sxsrf=ALiCzsb16F7oUzTE9Aac5Jxh1gYUPC1dAA%3A1668594033206&ei=cbl0Y-iNDKaNxc8PsYO6-Ac&ved=0ahUKEwioiv6UvbL7AhWmRvEDHbGBDn8Q4dUDCA8&uact=5&oq=White+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgkARoAHABeACAAWWIAWWSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Ballon+Wine+Glass&hl=en&sxsrf=ALiCzsbhDj1M1_XUz0bDO74I2ClBQnn36g%3A1668594047027&ei=f7l0Y5yhAdOFxc8P55G9oAQ&ved=0ahUKEwjc3MmbvbL7AhXTQvEDHedID0QQ4dUDCA8&uact=5&oq=Ballon+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIHCAAQgAQQCjIHCAAQgAQQCjIHCAAQgAQQCjIKCAAQFhAeEA8QCjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMggIABAWEB4QD0oECEEYAEoECEYYAFAAWABgxgFoAHABeACAAWqIAWqSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Wine+Tasting+Glass&hl=en&sxsrf=ALiCzsZFP7s2lnzXNi1TvQsnJuk2qHdkSg%3A1668594062150&ei=jrl0Y5DOCLqSxc8P0LC2iAQ&ved=0ahUKEwiQzeSivbL7AhU6SfEDHVCYDUEQ4dUDCA8&uact=5&oq=Wine+Tasting+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIAEMgUIABCABDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgzwFoAHABeACAAXKIAXKSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Sherry+Glass&hl=en&sxsrf=ALiCzsYBV8A6U6VwCHJlEyArnXD4QkyIUg%3A1668594074204&ei=mrl0Y_mDDLGFxc8PoZ2n-AY&ved=0ahUKEwj5uMSovbL7AhWxQvEDHaHOCW8Q4dUDCA8&uact=5&oq=Sherry+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyBQgAEIAEMggILhCABBDUAjIFCAAQgAQyBQgAEJECMgUIABCABDIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYL0FaABwAXgAgAGcAYgBnAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Champagne+Flute&hl=en&sxsrf=ALiCzsb-4DbDXUgk-c2RAK3lWdL3iuf5ZA%3A1668594132088&ei=1Ll0Y-H1BImQxc8PwNuHmA4&ved=0ahUKEwjhr5HEvbL7AhUJSPEDHcDtAeMQ4dUDCA8&uact=5&oq=Champagne+Flute&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9wFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Champagne+Coupe&hl=en&sxsrf=ALiCzsYSG73k8M9dBqZBv5NqfKRx4k0jOQ%3A1668594196658&ei=FLp0Y8XmJ8eMxc8Pjd6h0AE&ved=0ahUKEwjFwPbivbL7AhVHRvEDHQ1vCBoQ4dUDCA8&uact=5&oq=Champagne+Coupe&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9gFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Martini+Glass&hl=en&sxsrf=ALiCzsb7E6XWloUcn718PYvWpMoXoxeVcQ%3A1668594864123&ei=sLx0Y66IB5W9xc8PuOmuyAs&ved=0ahUKEwiuoJmhwLL7AhWVXvEDHbi0C7kQ4dUDCA8&uact=5&oq=Martini+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyBQgAEJECMgUIABCRAjIFCAAQkQIyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnwdoAHAAeACAAXmIAXmSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Margarita+Glass&hl=en&sxsrf=ALiCzsbD_7BOlu3uAGcVqV1qFsTP0wPiKA%3A1668594946758&ei=Ar10Y8vhLfC7xc8PleSNkAc&ved=0ahUKEwjL6szIwLL7AhXwXfEDHRVyA3IQ4dUDCA8&uact=5&oq=Margarita+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIICAAQgAQQywEyBAgAEEMyCggAEIAEEIcCEBQyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYL4CaABwAXgAgAFyiAFykgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Goblet+Glass&hl=en&sxsrf=ALiCzsbAZ61wMs1ecdMo5PV88PgKq4aZUw%3A1668594974987&ei=Hr10Y5PwO6eTxc8Pl-SJmAE&ved=0ahUKEwiT94fWwLL7AhWnSfEDHRdyAhMQ4dUDCA8&uact=5&oq=Goblet+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGDhAWgAcAF4AIABa4gBa5IBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Pokal+Glass&hl=en&sxsrf=ALiCzsa42LZ4PfpjzGaXj04rJXc-UOJahQ%3A1668594988929&ei=LL10Y6CbOKKTxc8Pn4Kx2A8&ved=0ahUKEwig4drcwLL7AhWiSfEDHR9BDPsQ4dUDCA8&uact=5&oq=Pokal+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCRAjIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYIMDaABwAXgAgAGJAYgBiQGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Milkshake+Glass&hl=en&sxsrf=ALiCzsaDvvzr8oRf7bGgCxlwz_JVLUWTXw%3A1668595001452&ei=Ob10Y7KBG6KSxc8PntGS-Ao&ved=0ahUKEwjygdfiwLL7AhUiSfEDHZ6oBK8Q4dUDCA8&uact=5&oq=Milkshake+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIFCAAQgAQyBAgAEEMyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYPcBaABwAXgAgAFviAFvkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Hurricane+Glass&hl=en&sxsrf=ALiCzsZe3r32UGH96fybE7WwJCDhwaKuYg%3A1668595020212&ei=TL10Y4K9DPGtxc8P14-64Ag&ved=0ahUKEwiCk9DrwLL7AhXxVvEDHdeHDowQ4dUDCA8&uact=5&oq=Hurricane+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyCggAEIAEEIcCEBQyBQgAEJECMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnAFoAHABeACAAX6IAX6SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Poco+Grande+Glass&hl=en&sxsrf=ALiCzsZxE3RSuuxxBVsQsqQE1mY4my4eZw%3A1668595032646&ei=WL10Y5mLJ5iExc8Px9CdsAM&ved=0ahUKEwiZl8fxwLL7AhUYQvEDHUdoBzYQ4dUDCA8&uact=5&oq=Poco+Grande+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABEoECEEYAEoECEYYAFAAWABgqAFoAHABeACAAXyIAXySAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Brandy+Snifter&hl=en&sxsrf=ALiCzsZNNDANMOfWDi63gU8kEaLt6-aaxQ%3A1668595044186&ei=ZL10Y4SEC8CBxc8P-P6YaA&ved=0ahUKEwiExof3wLL7AhXAQPEDHXg_Bg0Q4dUDCA8&uact=5&oq=Brandy+Snifter&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCBCGgAcAF4AIABd4gBd5IBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Wobble+Cognac+Glass&hl=en&sxsrf=ALiCzsbslu4l-7YPDgEjnhxyUb01ghWZKQ%3A1668595057314&ei=cb10Y7TbEsi_xc8PxZ6IyAc&ved=0ahUKEwj016j9wLL7AhXIX_EDHUUPAnkQ4dUDCA8&uact=5&oq=Wobble+Cognac+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIYDMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYLEBaABwAXgAgAF5iAF5kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Tulip+Whisky+Glass&hl=en&sxsrf=ALiCzsZqjgEcBXhP0F74w6ukhSdjlan1yg%3A1668595068685&ei=fL10Y7mUKeKExc8P3oOtsAE&ved=0ahUKEwi5wt6CwbL7AhViQvEDHd5BCxYQ4dUDCA8&uact=5&oq=Tulip+Whisky+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABghgFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Tulip+Glass&hl=en&sxsrf=ALiCzsY5AD5KJ64NlBoMbrgXc9nEVngljw%3A1668595084467&ei=jL10Y5iJHMaOxc8P16-VWA&ved=0ahUKEwiY_6GKwbL7AhVGR_EDHddXBQsQ4dUDCA8&uact=5&oq=Tulip+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYIgBaABwAXgAgAFyiAFykgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Grappa+Glass&hl=en&sxsrf=ALiCzsZEGOAmdlUCbrPSfHv79TXEN4XHBg%3A1668595098940&ei=mr10Y7b5OPiMxc8PoYedsA4&ved=0ahUKEwi2rpWRwbL7AhV4RvEDHaFDB-YQ4dUDCA8&uact=5&oq=Grappa+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCCA2gAcAF4AIABeIgBeJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Pousse+Cafe+Glass&hl=en&sxsrf=ALiCzsayNpwTrWErAORtXInTKGmPiEmgcw%3A1668595113445&ei=qb10Y5rbGv66xc8Pu4Gz-As&ved=0ahUKEwja04qYwbL7AhV-XfEDHbvADL8Q4dUDCA8&uact=5&oq=Pousse+Cafe+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIFCAAQhgMyBQgAEIYDMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYNsCaABwAXgAgAGAAYgBgAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Cordial+Glass&hl=en&sxsrf=ALiCzsYgPJPMIWXBzryN9c8CkrFt_UFWoQ%3A1668595125086&ei=tb10Y5rnBPWBxc8PjcGv-Ag&ved=0ahUKEwjaldGdwbL7AhX1QPEDHY3gC48Q4dUDCA8&uact=5&oq=Cordial+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgfmgAcAB4AIABAIgBAJIBAJgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Absinthe+Glass&hl=en&sxsrf=ALiCzsb1qF2QVishHqOISrTAq8krWmY2fA%3A1668595137676&ei=wb10Y7z0KN2Uxc8P8fW1sAg&ved=0ahUKEwj82NGjwbL7AhVdSvEDHfF6DYYQ4dUDCA8&uact=5&oq=Absinthe+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgQIABBDMgUIABCABEoECEEYAEoECEYYAFAAWABgjgFoAHABeACAAXOIAXOSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Vodka+Glass&hl=en&sxsrf=ALiCzsYxVsK6UlZJvje9KDHv5qfRj3SdKg%3A1668595147610&ei=y710Y6DfJJG-xc8PxZGI2AY&ved=0ahUKEwjg8K-owbL7AhURX_EDHcUIAmsQ4dUDCA8&uact=5&oq=Vodka+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgtANoAHABeACAAXqIAXqSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Shooter+Glass&hl=en&sxsrf=ALiCzsYCiHwVGHnonR3h9IiOti6KcMT2oA%3A1668595161113&ei=2b10Y5S_BoCPxc8Puem40Ak&ved=0ahUKEwjUj-iuwbL7AhWAR_EDHbk0DpoQ4dUDCA8&uact=5&oq=Shooter+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIHCAAQgAQQCjIFCAAQgAQyBwgAEIAEEAoyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgsQFoAHABeACAAXuIAXuSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Glasses",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Shot+Glass&hl=en&sxsrf=ALiCzsaicIYZvf42TLqqcQM_w1awx-68Hg%3A1668595172668&ei=5L10Y4mvKMiMxc8P7aKomAc&ved=0ahUKEwiJsam0wbL7AhVIRvEDHW0RCnMQ4dUDCA8&uact=5&oq=Shot+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIECAAQQzIECAAQQzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBAgAEEMyBQgAEIAEMgQIABBDMgUIABCABEoECEEYAEoECEYYAFAAWABgzwFoAHABeACAAW2IAW2SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Cocktail+Gauguin&hl=en&sxsrf=ALiCzsYZijqseouEFjzKEYTw-66_8uzpsA%3A1668594209334&ei=Ibp0Y5P1E_GTxc8PpdmT8AI&ved=0ahUKEwjTifzovbL7AhXxSfEDHaXsBC4Q4dUDCA8&uact=5&oq=Cocktail+Gauguin&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIGCAAQFhAeOgoIABBHENYEELADOgcIABCwAxBDOg0IABDkAhDWBBCwAxgBOhIILhDHARDRAxDIAxCwAxBDGAI6FQguEMcBENEDENQCEMgDELADEEMYAjoECAAQQzoKCC4QxwEQ0QMQQzoQCC4QgAQQhwIQxwEQ0QMQFDoFCAAQgAQ6CwguEIAEEMcBENEDOgcILhDUAhBDOggILhCABBDUAjoKCC4Q1AIQgAQQQzoICAAQgAQQyQM6DgguEIAEEMcBEK8BEMsBSgQIQRgASgQIRhgBUNIJWNQmYKUuaARwAXgAgAGNAYgBmQmSAQQwLjEwmAEAoAEBoAECyAERwAEB2gEGCAEQARgJ2gEGCAIQARgI&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=sex+on+the+beach+cocktail&hl=en&sxsrf=ALiCzsbVoUJDMmVhnd712I2_OEi4zn8HKQ%3A1668597389724&ei=jcZ0Y8DaK7CWxc8P7pS3uAs&gs_ssp=eJzj4tLP1TcwKsqotCg2YHRg8JIsTq1QyM9TKMlIVUhKTUzOUEjOT84uSczMAQAB0Q0_&oq=Sex+on+the+Beach+&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgAMgcILhCABBBDMgQIABBDMggILhCABBDLATIICAAQgAQQywEyBQgAEIAEMgQIABBDMgQIABBDMgUIABCABDIFCAAQgAQyCggAEIAEEIcCEBRKBAhBGABKBAhGGABQAFi5A2DBIGgAcAF4AIABnQGIAY4CkgEDMC4ymAEAoAECoAEBwAEB&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Cheshire+Cat+Cocktail&sxsrf=ALiCzsYnvGR_m4i19I70GL1_6ctyPC0kCg%3A1668601527470&ei=t9Z0Y62oHP-Pxc8PoaufkAM&ved=0ahUKEwjt38OK2bL7AhX_R_EDHaHVBzIQ4dUDCA8&uact=5&oq=Cheshire+Cat+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMggIABAWEB4QDzIFCAAQhgMyBQgAEIYDMgUIABCGAzIFCAAQhgMyBQgAEIYDOgoIABBHENYEELADOgcIABCwAxBDOg0IABDkAhDWBBCwAxgBOgwILhDIAxCwAxBDGAI6DwguENQCEMgDELADEEMYAjoECAAQQzoICAAQgAQQywE6BQghEKABSgQIQRgASgQIRhgBUJcBWN8qYN0uaANwAXgAgAGTAYgB8gmSAQQxLjEwmAEAoAEByAETwAEB2gEGCAEQARgJ2gEGCAIQARgI&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Mexicana+Cocktail&sxsrf=ALiCzsbqImQPN1VjWrRYrgZM5Fnv2oYZ3Q%3A1668601536059&ei=wNZ0Y5WXA9uIxc8P_c2z4AY&ved=0ahUKEwiV98-O2bL7AhVbRPEDHf3mDGwQ4dUDCA8&uact=5&oq=Mexicana+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyCAgAEIAEEMsBMggIABAWEB4QCjIGCAAQFhAeMgYIABAWEB4yCAgAEBYQHhAKMgYIABAWEB4yCggAEBYQHhAPEAoyCAgAEBYQHhAKMgYIABAWEB46BQguEIAEOgUIIRCgAToKCAAQgAQQhwIQFDoHCAAQgAQQCjoICAAQFhAeEA9KBAhBGABKBAhGGABQAFioNWCrN2gCcAF4AIABigGIAfgJkgEEMC4xMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Slippery+Nipple+Cocktail&sxsrf=ALiCzsZ4y_0nwTU0wFWwU8KO1G0xUdBsSA%3A1668601931172&ei=S9h0Y9b_CYqqxc8P68qFyA4&ved=0ahUKEwiW0YPL2rL7AhUKVfEDHWtlAekQ4dUDCA8&uact=5&oq=Slippery+Nipple+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCC4QgAQQhwIQFDIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIFCAAQhgMyBQgAEIYDOgYIABAHEB46BQguEIAEOgYIABAIEB5KBAhBGABKBAhGGABQAFgAYP4haABwAXgAgAGjAogBpgOSAQUwLjEuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.google.com/search?q=Bitter+Sweet+Cocktail&sxsrf=ALiCzsYtnnGfQTc9sgKc8-ouqUjsQ4hILg%3A1668602388689&ei=FNp0Y7PUKc-Xxc8P0MOomA4&ved=0ahUKEwizrpil3LL7AhXPS_EDHdAhCuMQ4dUDCA8&uact=5&oq=Bitter+Sweet+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIGCAAQBxAeMgUIABCABDIFCAAQgAQyCAgAEAgQHhAKMgYIABAIEB4yBQgAEIYDMgUIABCGAzoLCAAQBxAeELADEAo6BwgAELADEEM6CAgAEIAEELADOgsIABCABBCwAxDLAToJCAAQCBAeELADOgwILhDIAxCwAxBDGAE6DwguENQCEMgDELADEEMYAUoECEEYAUoECEYYAVDHggtYx4ILYJ6MC2gBcAB4AIABfIgBfJIBAzAuMZgBAKABAqABAcgBEsABAdoBBggBEAEYCA&sclient=gws-wiz-serp");
        }
    }
}
