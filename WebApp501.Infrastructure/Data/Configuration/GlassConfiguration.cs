using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    /// <summary>
    /// Adds seed data to this entity type.
    /// </summary>
    internal class GlassConfiguration : IEntityTypeConfiguration<Glass>
    {
        public void Configure(EntityTypeBuilder<Glass> builder)
        {
            builder
                .HasData(CreateGlasses());
        }

        private List<Glass> CreateGlasses()
        {
            var glasses = new List<Glass>()
            {
                new Glass()
                {
                    Id = 1,
                    Name = "Old Fashioned Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/51ErdYtGOAL.jpg"
                },
                new Glass()
                {
                    Id = 2,
                    Name = "Rocks Glass",
                    ImageUrl = "https://www.cocktailkingdom.com/media/catalog/product/cache/1/image/364x/040ec09b1e35df139433887a97daa66f/g/l/gla_ckrksyarai_6101_clr_web1_1.jpg"
                },
                new Glass()
                {
                    Id = 3,
                    Name = "Cosmopolitan Glass",
                    ImageUrl = "https://johnlewis.scene7.com/is/image/JohnLewis/233596730?$rsp-pdp-port-640$"
                },
                new Glass()
                {
                    Id = 4,
                    Name = "Highball Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/31ncXtqfK7L._SL500_.jpg"
                },
                new Glass()
                {
                    Id = 5,
                    Name = "Collins Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/31vvQmBDhdL.jpg"
                },
                new Glass()
                {
                    Id = 6,
                    Name = "Zombie Glass",
                    ImageUrl = "https://cdn.shoplightspeed.com/shops/606142/files/5865756/1500x4000x3/fizz-zombie-glass-135-oz.jpg"
                },
                new Glass()
                {
                    Id = 7,
                    Name = "Weizen Glass",
                    ImageUrl = "https://hosteleria.araven.com/sites/default/files/styles/producto/public/91641_copa_weiser_cerveza.jpg?itok=9N2yaZRa"
                },
                new Glass()
                {
                    Id = 8,
                    Name = "Pilsner Glass",
                    ImageUrl = "https://www.ikea.com/my/en/images/products/oanvaend-beer-glass-clear-glass__0713254_pe729369_s5.jpg"
                },
                new Glass()
                {
                    Id = 9,
                    Name = "Sling Glass",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0520/0943/5294/products/UB15.jpg?v=1616053755"
                },
                new Glass()
                {
                    Id = 10,
                    Name = "Pint Glass",
                    ImageUrl = "https://cdnimg.webstaurantstore.com/images/products/large/41072/2310339.jpg"
                },
                new Glass()
                {
                    Id = 11,
                    Name = "Beer Mug",
                    ImageUrl = "https://www.ikea.com/us/en/images/products/mjoed-beer-mug-clear-glass__0525765_pe644916_s5.jpg?f=s"
                },
                new Glass()
                {
                    Id = 12,
                    Name = "Irish Coffee Glass",
                    ImageUrl = "https://www.sbb-bg.com/image/cache/catalog/images/Uniglass/1076_44856-550x700w.jpg"
                },
                new Glass()
                {
                    Id = 13,
                    Name = "Red Wine Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/51pEW1I+FJL._SY879_.jpg"
                },
                new Glass()
                {
                    Id = 14,
                    Name = "White Wine Glass",
                    ImageUrl = "https://www.ikea.com/gb/en/images/products/dyrgrip-white-wine-glass-clear-glass__0712421_pe728840_s5.jpg?f=s"
                },
                new Glass()
                {
                    Id = 15,
                    Name = "Ballon Wine Glass",
                    ImageUrl = "https://www.intornoalvino.com/731-large_default/red-wine-glasses-ballon-vineas.jpg"
                },
                new Glass()
                {
                    Id = 16,
                    Name = "Wine Tasting Glass",
                    ImageUrl = "https://media.nisbets.com/asset/core/prodimage/large_new/gf738_g817-1707.jpg"
                },
                new Glass()
                {
                    Id = 17,
                    Name = "Sherry Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/61DcUapHwjL.jpg"
                },
                new Glass()
                {
                    Id = 18,
                    Name = "Champagne Flute",
                    ImageUrl = "https://5.imimg.com/data5/CU/RU/SE/SELLER-25193472/ocean-champagne-flute-glass-500x500.jpg"
                },
                new Glass()
                {
                    Id = 19,
                    Name = "Champagne Coupe",
                    ImageUrl = "https://www.ikea.com/gb/en/images/products/storhet-champagne-coupe-clear-glass__0713258_pe729368_s5.jpg"
                },
                new Glass()
                {
                    Id = 20,
                    Name = "Martini Glass",
                    ImageUrl = "https://www.ikea.com/ca/en/images/products/storsint-martini-glass-clear-glass__0800268_pe767839_s5.jpg"
                },
                new Glass()
                {
                    Id = 21,
                    Name = "Margarita Glass",
                    ImageUrl = "https://www.ikea.com/om/en/images/products/festlighet-margarita-glass__0712417_pe728836_s5.jpg?f=s"
                },
                new Glass()
                {
                    Id = 22,
                    Name = "Goblet Glass",
                    ImageUrl = "https://www.webstaurantstore.com/images/products/large/88017/1877520.jpg"
                },
                new Glass()
                {
                    Id = 23,
                    Name = "Pokal Glass",
                    ImageUrl = "http://www.ajmara.pl/upd_cnt/attch/img_pro/colibri_pokal_do_piwa.jpg"
                },
                new Glass()
                {
                    Id = 24,
                    Name = "Milkshake Glass",
                    ImageUrl = "https://www.drinkstuff.com/productimg/47978_large.jpg"
                },
                new Glass()
                {
                    Id = 25,
                    Name = "Hurricane Glass",
                    ImageUrl = "https://cdnimg.webstaurantstore.com/images/products/large/232957/2396272.jpg"
                },
                new Glass()
                {
                    Id = 26,
                    Name = "Poco Grande Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/41a1riW3YxL.jpg"
                },
                new Glass()
                {
                    Id = 27,
                    Name = "Brandy Snifter",
                    ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1571017071-31p5xeITE9L.jpg?crop=1xw:0.938xh"
                },
                new Glass()
                {
                    Id = 28,
                    Name = "Wobble Cognac Glass",
                    ImageUrl = "http://1.bp.blogspot.com/-ZWq1ngNmIQM/VGZVL090-CI/AAAAAAAAbtU/L1lk0iv8_kQ/s1600/Cognac-Delamain-with-Baccarat-Le-Voyage-Decanter-Bottle-2.jpg"
                },
                new Glass()
                {
                    Id = 29,
                    Name = "Tulip Whisky Glass",
                    ImageUrl = "https://boomingglassware.com/wp-content/uploads/2019/08/BMWky-02%EF%BC%881%EF%BC%89.jpg"
                },
                new Glass()
                {
                    Id = 30,
                    Name = "Tulip Glass",
                    ImageUrl = "https://glassmania.com/media/catalog/product/cache/6b9c9ff9456b96523530d9a877110061/n/v/nvr42bsen_1.png"
                },
                new Glass()
                {
                    Id = 31,
                    Name = "Grappa Glass",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0615/8575/2295/products/Plain_-_Vintage_Grappa_Glass_-_66110_-_1052488_v1_1800x1800_56febef2-76df-4c4a-9a15-33d885d9944d_1500x.jpg?v=1640309929"
                },
                new Glass()
                {
                    Id = 32,
                    Name = "Pousse Cafe Glass",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKc6d02gFVbrW57FF9OVXAiqUcAb8YkgPhGMWGpxaCGQ&s"
                },
                new Glass()
                {
                    Id = 33,
                    Name = "Cordial Glass",
                    ImageUrl = "https://secure.img1-cg.wfcdn.com/im/54073283/resize-h600-w600%5Ecompr-r85/1612/16121821/Cordial+Glasses.jpg"
                },
                new Glass()
                {
                    Id = 34,
                    Name = "Absinthe Glass",
                    ImageUrl = "https://assets.manufactum.de/p/020/020056/20056_01.jpg/absinthe-glass-la-rochere.jpg"
                },
                new Glass()
                {
                    Id = 35,
                    Name = "Vodka Glass",
                    ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/vodka-glasses-1638468889.jpg?crop=0.502xw:1.00xh;0.250xw,0&resize=640:*"
                },
                new Glass()
                {
                    Id = 36,
                    Name = "Shooter Glass",
                    ImageUrl = "https://m.media-amazon.com/images/I/51MpZbNhM-L.jpg"
                },
                new Glass()
                {
                    Id = 37,
                    Name = "Shot Glass",
                    ImageUrl = "https://media.istockphoto.com/id/178410979/photo/empty-glass.jpg?s=612x612&w=0&k=20&c=BcS4A2H_nxwc4uTWOHb2vRjLs_DgIOWk2aL4tKDzHv4="
                }
            };

            return glasses;
        }
    }
}