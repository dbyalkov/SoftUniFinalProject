using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
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
                    ImageUrl = "https://www.google.com/search?q=Old+Fashioned+Glass&bih=937&biw=1920&hl=en&sxsrf=ALiCzsZksVXX7Jp6cFoRTLguZ9_rFgP01w%3A1668593623124&ei=17d0Y6CXB4XAxc8P5qePoA0&ved=0ahUKEwjg3rjRu7L7AhUFYPEDHebTA9QQ4dUDCA8&uact=5&oq=Old+Fashioned+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIECAAQQzIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYN0DaABwAXgAgAFniAFnkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 2,
                    Name = "Rocks Glass",
                    ImageUrl = "https://www.google.com/search?q=Rocks+Glass&source=lmns&bih=937&biw=1920&hl=en&sa=X&ved=2ahUKEwjDgsTMu7L7AhUzhP0HHSXuDhEQ_AUoAHoECAEQAA"
                },
                new Glass()
                {
                    Id = 3,
                    Name = "Cosmopolitan Glass",
                    ImageUrl = "https://www.google.com/search?q=Cosmopolitan+Glass&hl=en&sxsrf=ALiCzsakKsEMVyRGZAk7S8Zs_2iykuym5A%3A1668593676149&ei=DLh0Y5XRCJSGxc8PxOKX2AY&ved=0ahUKEwiVh93qu7L7AhUUQ_EDHUTxBWsQ4dUDCA8&uact=5&oq=Cosmopolitan+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGDSAWgAcAF4AIABdIgBdJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 4,
                    Name = "Highball Glass",
                    ImageUrl = "https://www.google.com/search?q=Highball+Glass&hl=en&sxsrf=ALiCzsZF3422_khQfxrWIHjSUWIgy0Ot0A%3A1668593702256&ei=Jrh0Y9aVD-2Sxc8P7-yOqA4&ved=0ahUKEwjWwJb3u7L7AhVtSfEDHW-2A-UQ4dUDCA8&uact=5&oq=Highball+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCRAjIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYLsBaABwAXgAgAGEAYgBhAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 5,
                    Name = "Collins Glass",
                    ImageUrl = "https://www.google.com/search?q=Collins+Glass&hl=en&sxsrf=ALiCzsacdfcPWofspFyJ4YW4-C9A0zbB_w%3A1668593720648&ei=OLh0Y6WKJ6yFxc8Phv296Aw&ved=0ahUKEwilhvn_u7L7AhWsQvEDHYZ-D80Q4dUDCA8&uact=5&oq=Collins+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYKkDaABwAXgAgAF5iAF5kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 6,
                    Name = "Zombie Glass",
                    ImageUrl = "https://www.google.com/search?q=Zombie+Glass&hl=en&sxsrf=ALiCzsb9Onseh4wmGEC1WkKh5Vf-ZoEKuQ%3A1668593737947&ei=Sbh0Y4WvOfa_xc8PgKmUsA8&ved=0ahUKEwjF95iIvLL7AhX2X_EDHYAUBfYQ4dUDCA8&uact=5&oq=Zombie+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9gJoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 7,
                    Name = "Weizen Glass",
                    ImageUrl = "https://www.google.com/search?q=Weizen+Glass&hl=en&sxsrf=ALiCzsZSN98V4C5ier_raFN6DNaXJ3rDiw%3A1668593801173&ei=ibh0Y8qQCqyNxc8PobqUEA&ved=0ahUKEwiK-aumvLL7AhWsRvEDHSEdBQIQ4dUDCA8&uact=5&oq=Weizen+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIFCAAQkQIyBQgAEIAEMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIICAAQFhAeEAoyBggAEBYQHjIGCAAQFhAeSgQIQRgASgQIRhgAUABYAGCnBGgAcAF4AIABeYgBeZIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 8,
                    Name = "Pilsner Glass",
                    ImageUrl = "https://www.google.com/search?q=Pilsner+Glass&hl=en&sxsrf=ALiCzsZO_TUrNQyiWYXd8YLg_RxexCkecg%3A1668593813987&ei=lbh0Y6PsO7erxc8P04mjgAc&ved=0ahUKEwjjirqsvLL7AhW3VfEDHdPECHAQ4dUDCA8&uact=5&oq=Pilsner+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCXAmgAcAB4AIABaIgBaJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 9,
                    Name = "Sling Glass",
                    ImageUrl = "https://www.google.com/search?q=Sling+Glass&hl=en&sxsrf=ALiCzsYiTS2gLkSIaOBNIKHtqcHCYSA8Dw%3A1668593841539&ei=sbh0Y7rBIJaPxc8Pk7SzuAU&ved=0ahUKEwj63cu5vLL7AhWWR_EDHRPaDFcQ4dUDCA8&uact=5&oq=Sling+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgcIABCABBAKMgUIABCABDIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeSgQIQRgASgQIRhgAUABYAGCUAWgAcAF4AIABhAGIAYQBkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 10,
                    Name = "Pint Glass",
                    ImageUrl = "https://www.google.com/search?q=Pint+Glass&hl=en&sxsrf=ALiCzsaKQCMC6IZ87woS9FzjcIdn3LgX3g%3A1668593853854&ei=vbh0Y7HVM8WSxc8P6pioqAc&ved=0ahUKEwjxp7u_vLL7AhVFSfEDHWoMCnUQ4dUDCA8&uact=5&oq=Pint+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgdGgAcAF4AIABAIgBAJIBAJgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 11,
                    Name = "Beer Mug",
                    ImageUrl = "https://www.google.com/search?q=Beer+Mug&hl=en&sxsrf=ALiCzsZXZ5ODI_ByrlwseAtObG8aAzXhAw%3A1668593867431&ei=y7h0Y6bxGZ6rxc8Pgoa-4Ao&ved=0ahUKEwjmgvjFvLL7AhWeVfEDHQKDD6wQ4dUDCA8&uact=5&oq=Beer+Mug&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnAFoAHABeACAAW-IAW-SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 12,
                    Name = "Irish Coffee Glass",
                    ImageUrl = "https://www.google.com/search?q=Irish+Coffee+Glass&hl=en&sxsrf=ALiCzsbHsswfqUjLnQcq4wB2AKgCa7fI0A%3A1668593882299&ei=2rh0Y4jfEe6Xxc8PyLGe4AU&ved=0ahUKEwiItIPNvLL7AhXuS_EDHciYB1wQ4dUDCA8&uact=5&oq=Irish+Coffee+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgiAdoAHAAeACAAXGIAXGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 13,
                    Name = "Red Wine Glass",
                    ImageUrl = "https://www.google.com/search?q=Red+Wine+Glass&hl=en&sxsrf=ALiCzsaTXw7Grstwjekn_pBLB9igMnC0eQ%3A1668594006964&ei=Vrl0Y8K-Or6Bxc8PwvOQMA&ved=0ahUKEwjCwbyIvbL7AhW-QPEDHcI5BAYQ4dUDCA8&uact=5&oq=Red+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgvAFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 14,
                    Name = "White Wine Glass",
                    ImageUrl = "https://www.google.com/search?q=White+Wine+Glass&hl=en&sxsrf=ALiCzsb16F7oUzTE9Aac5Jxh1gYUPC1dAA%3A1668594033206&ei=cbl0Y-iNDKaNxc8PsYO6-Ac&ved=0ahUKEwioiv6UvbL7AhWmRvEDHbGBDn8Q4dUDCA8&uact=5&oq=White+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgkARoAHABeACAAWWIAWWSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 15,
                    Name = "Ballon Wine Glass",
                    ImageUrl = "https://www.google.com/search?q=Ballon+Wine+Glass&hl=en&sxsrf=ALiCzsbhDj1M1_XUz0bDO74I2ClBQnn36g%3A1668594047027&ei=f7l0Y5yhAdOFxc8P55G9oAQ&ved=0ahUKEwjc3MmbvbL7AhXTQvEDHedID0QQ4dUDCA8&uact=5&oq=Ballon+Wine+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIHCAAQgAQQCjIHCAAQgAQQCjIHCAAQgAQQCjIKCAAQFhAeEA8QCjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMggIABAWEB4QD0oECEEYAEoECEYYAFAAWABgxgFoAHABeACAAWqIAWqSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 16,
                    Name = "Wine Tasting Glass",
                    ImageUrl = "https://www.google.com/search?q=Wine+Tasting+Glass&hl=en&sxsrf=ALiCzsZFP7s2lnzXNi1TvQsnJuk2qHdkSg%3A1668594062150&ei=jrl0Y5DOCLqSxc8P0LC2iAQ&ved=0ahUKEwiQzeSivbL7AhU6SfEDHVCYDUEQ4dUDCA8&uact=5&oq=Wine+Tasting+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIAEMgUIABCABDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgzwFoAHABeACAAXKIAXKSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 17,
                    Name = "Sherry Glass",
                    ImageUrl = "https://www.google.com/search?q=Sherry+Glass&hl=en&sxsrf=ALiCzsYBV8A6U6VwCHJlEyArnXD4QkyIUg%3A1668594074204&ei=mrl0Y_mDDLGFxc8PoZ2n-AY&ved=0ahUKEwj5uMSovbL7AhWxQvEDHaHOCW8Q4dUDCA8&uact=5&oq=Sherry+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyBQgAEIAEMggILhCABBDUAjIFCAAQgAQyBQgAEJECMgUIABCABDIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYL0FaABwAXgAgAGcAYgBnAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 18,
                    Name = "Champagne Flute",
                    ImageUrl = "https://www.google.com/search?q=Champagne+Flute&hl=en&sxsrf=ALiCzsb-4DbDXUgk-c2RAK3lWdL3iuf5ZA%3A1668594132088&ei=1Ll0Y-H1BImQxc8PwNuHmA4&ved=0ahUKEwjhr5HEvbL7AhUJSPEDHcDtAeMQ4dUDCA8&uact=5&oq=Champagne+Flute&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9wFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 19,
                    Name = "Champagne Coupe",
                    ImageUrl = "https://www.google.com/search?q=Champagne+Coupe&hl=en&sxsrf=ALiCzsYSG73k8M9dBqZBv5NqfKRx4k0jOQ%3A1668594196658&ei=FLp0Y8XmJ8eMxc8Pjd6h0AE&ved=0ahUKEwjFwPbivbL7AhVHRvEDHQ1vCBoQ4dUDCA8&uact=5&oq=Champagne+Coupe&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABg9gFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 20,
                    Name = "Martini Glass",
                    ImageUrl = "https://www.google.com/search?q=Martini+Glass&hl=en&sxsrf=ALiCzsb7E6XWloUcn718PYvWpMoXoxeVcQ%3A1668594864123&ei=sLx0Y66IB5W9xc8PuOmuyAs&ved=0ahUKEwiuoJmhwLL7AhWVXvEDHbi0C7kQ4dUDCA8&uact=5&oq=Martini+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyBQgAEJECMgUIABCRAjIFCAAQkQIyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnwdoAHAAeACAAXmIAXmSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 21,
                    Name = "Margarita Glass",
                    ImageUrl = "https://www.google.com/search?q=Margarita+Glass&hl=en&sxsrf=ALiCzsbD_7BOlu3uAGcVqV1qFsTP0wPiKA%3A1668594946758&ei=Ar10Y8vhLfC7xc8PleSNkAc&ved=0ahUKEwjL6szIwLL7AhXwXfEDHRVyA3IQ4dUDCA8&uact=5&oq=Margarita+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIICAAQgAQQywEyBAgAEEMyCggAEIAEEIcCEBQyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYL4CaABwAXgAgAFyiAFykgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 22,
                    Name = "Goblet Glass",
                    ImageUrl = "https://www.google.com/search?q=Goblet+Glass&hl=en&sxsrf=ALiCzsbAZ61wMs1ecdMo5PV88PgKq4aZUw%3A1668594974987&ei=Hr10Y5PwO6eTxc8Pl-SJmAE&ved=0ahUKEwiT94fWwLL7AhWnSfEDHRdyAhMQ4dUDCA8&uact=5&oq=Goblet+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGDhAWgAcAF4AIABa4gBa5IBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 23,
                    Name = "Pokal Glass",
                    ImageUrl = "https://www.google.com/search?q=Pokal+Glass&hl=en&sxsrf=ALiCzsa42LZ4PfpjzGaXj04rJXc-UOJahQ%3A1668594988929&ei=LL10Y6CbOKKTxc8Pn4Kx2A8&ved=0ahUKEwig4drcwLL7AhWiSfEDHR9BDPsQ4dUDCA8&uact=5&oq=Pokal+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCRAjIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYIMDaABwAXgAgAGJAYgBiQGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 24,
                    Name = "Milkshake Glass",
                    ImageUrl = "https://www.google.com/search?q=Milkshake+Glass&hl=en&sxsrf=ALiCzsaDvvzr8oRf7bGgCxlwz_JVLUWTXw%3A1668595001452&ei=Ob10Y7KBG6KSxc8PntGS-Ao&ved=0ahUKEwjygdfiwLL7AhUiSfEDHZ6oBK8Q4dUDCA8&uact=5&oq=Milkshake+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIFCAAQgAQyBAgAEEMyBQgAEIAEMgQIABBDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYPcBaABwAXgAgAFviAFvkgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 25,
                    Name = "Hurricane Glass",
                    ImageUrl = "https://www.google.com/search?q=Hurricane+Glass&hl=en&sxsrf=ALiCzsZe3r32UGH96fybE7WwJCDhwaKuYg%3A1668595020212&ei=TL10Y4K9DPGtxc8P14-64Ag&ved=0ahUKEwiCk9DrwLL7AhXxVvEDHdeHDowQ4dUDCA8&uact=5&oq=Hurricane+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQkQIyCggAEIAEEIcCEBQyBQgAEJECMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgnAFoAHABeACAAX6IAX6SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 26,
                    Name = "Poco Grande Glass",
                    ImageUrl = "https://www.google.com/search?q=Poco+Grande+Glass&hl=en&sxsrf=ALiCzsZxE3RSuuxxBVsQsqQE1mY4my4eZw%3A1668595032646&ei=WL10Y5mLJ5iExc8Px9CdsAM&ved=0ahUKEwiZl8fxwLL7AhUYQvEDHUdoBzYQ4dUDCA8&uact=5&oq=Poco+Grande+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgoIABCABBCHAhAUMgUIABCABEoECEEYAEoECEYYAFAAWABgqAFoAHABeACAAXyIAXySAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 27,
                    Name = "Brandy Snifter",
                    ImageUrl = "https://www.google.com/search?q=Brandy+Snifter&hl=en&sxsrf=ALiCzsZNNDANMOfWDi63gU8kEaLt6-aaxQ%3A1668595044186&ei=ZL10Y4SEC8CBxc8P-P6YaA&ved=0ahUKEwiExof3wLL7AhXAQPEDHXg_Bg0Q4dUDCA8&uact=5&oq=Brandy+Snifter&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCBCGgAcAF4AIABd4gBd5IBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 28,
                    Name = "Wobble Cognac Glass",
                    ImageUrl = "https://www.google.com/search?q=Wobble+Cognac+Glass&hl=en&sxsrf=ALiCzsbslu4l-7YPDgEjnhxyUb01ghWZKQ%3A1668595057314&ei=cb10Y7TbEsi_xc8PxZ6IyAc&ved=0ahUKEwj016j9wLL7AhXIX_EDHUUPAnkQ4dUDCA8&uact=5&oq=Wobble+Cognac+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBQgAEIYDMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYLEBaABwAXgAgAF5iAF5kgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 29,
                    Name = "Tulip Whisky Glass",
                    ImageUrl = "https://www.google.com/search?q=Tulip+Whisky+Glass&hl=en&sxsrf=ALiCzsZqjgEcBXhP0F74w6ukhSdjlan1yg%3A1668595068685&ei=fL10Y7mUKeKExc8P3oOtsAE&ved=0ahUKEwi5wt6CwbL7AhViQvEDHd5BCxYQ4dUDCA8&uact=5&oq=Tulip+Whisky+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABghgFoAHABeACAAQCIAQCSAQCYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 30,
                    Name = "Tulip Glass",
                    ImageUrl = "https://www.google.com/search?q=Tulip+Glass&hl=en&sxsrf=ALiCzsY5AD5KJ64NlBoMbrgXc9nEVngljw%3A1668595084467&ei=jL10Y5iJHMaOxc8P16-VWA&ved=0ahUKEwiY_6GKwbL7AhVGR_EDHddXBQsQ4dUDCA8&uact=5&oq=Tulip+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgARKBAhBGABKBAhGGABQAFgAYIgBaABwAXgAgAFyiAFykgEDMC4xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 31,
                    Name = "Grappa Glass",
                    ImageUrl = "https://www.google.com/search?q=Grappa+Glass&hl=en&sxsrf=ALiCzsZEGOAmdlUCbrPSfHv79TXEN4XHBg%3A1668595098940&ei=mr10Y7b5OPiMxc8PoYedsA4&ved=0ahUKEwi2rpWRwbL7AhV4RvEDHaFDB-YQ4dUDCA8&uact=5&oq=Grappa+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAESgQIQRgASgQIRhgAUABYAGCCA2gAcAF4AIABeIgBeJIBAzAuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 32,
                    Name = "Pousse Cafe Glass",
                    ImageUrl = "https://www.google.com/search?q=Pousse+Cafe+Glass&hl=en&sxsrf=ALiCzsayNpwTrWErAORtXInTKGmPiEmgcw%3A1668595113445&ei=qb10Y5rbGv66xc8Pu4Gz-As&ved=0ahUKEwja04qYwbL7AhV-XfEDHbvADL8Q4dUDCA8&uact=5&oq=Pousse+Cafe+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIFCAAQhgMyBQgAEIYDMgUIABCGAzIFCAAQhgNKBAhBGABKBAhGGABQAFgAYNsCaABwAXgAgAGAAYgBgAGSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 33,
                    Name = "Cordial Glass",
                    ImageUrl = "https://www.google.com/search?q=Cordial+Glass&hl=en&sxsrf=ALiCzsYgPJPMIWXBzryN9c8CkrFt_UFWoQ%3A1668595125086&ei=tb10Y5rnBPWBxc8PjcGv-Ag&ved=0ahUKEwjaldGdwbL7AhX1QPEDHY3gC48Q4dUDCA8&uact=5&oq=Cordial+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQA0oECEEYAEoECEYYAFAAWABgfmgAcAB4AIABAIgBAJIBAJgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 34,
                    Name = "Absinthe Glass",
                    ImageUrl = "https://www.google.com/search?q=Absinthe+Glass&hl=en&sxsrf=ALiCzsb1qF2QVishHqOISrTAq8krWmY2fA%3A1668595137676&ei=wb10Y7z0KN2Uxc8P8fW1sAg&ved=0ahUKEwj82NGjwbL7AhVdSvEDHfF6DYYQ4dUDCA8&uact=5&oq=Absinthe+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIECAAQQzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyCggAEIAEEIcCEBQyBQgAEIAEMgQIABBDMgUIABCABEoECEEYAEoECEYYAFAAWABgjgFoAHABeACAAXOIAXOSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 35,
                    Name = "Vodka Glass",
                    ImageUrl = "https://www.google.com/search?q=Vodka+Glass&hl=en&sxsrf=ALiCzsYxVsK6UlZJvje9KDHv5qfRj3SdKg%3A1668595147610&ei=y710Y6DfJJG-xc8PxZGI2AY&ved=0ahUKEwjg8K-owbL7AhURX_EDHcUIAmsQ4dUDCA8&uact=5&oq=Vodka+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIFCAAQkQIyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgtANoAHABeACAAXqIAXqSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 36,
                    Name = "Shooter Glass",
                    ImageUrl = "https://www.google.com/search?q=Shooter+Glass&hl=en&sxsrf=ALiCzsYCiHwVGHnonR3h9IiOti6KcMT2oA%3A1668595161113&ei=2b10Y5S_BoCPxc8Puem40Ak&ved=0ahUKEwjUj-iuwbL7AhWAR_EDHbk0DpoQ4dUDCA8&uact=5&oq=Shooter+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBQgAEIAEMgUIABCABDIHCAAQgAQQCjIFCAAQgAQyBwgAEIAEEAoyBQgAEIAEMgUIABCABEoECEEYAEoECEYYAFAAWABgsQFoAHABeACAAXuIAXuSAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                },
                new Glass()
                {
                    Id = 37,
                    Name = "Shot Glass",
                    ImageUrl = "https://www.google.com/search?q=Shot+Glass&hl=en&sxsrf=ALiCzsaicIYZvf42TLqqcQM_w1awx-68Hg%3A1668595172668&ei=5L10Y4mvKMiMxc8P7aKomAc&ved=0ahUKEwiJsam0wbL7AhVIRvEDHW0RCnMQ4dUDCA8&uact=5&oq=Shot+Glass&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECAAQQzIECAAQQzIECAAQQzIKCAAQgAQQhwIQFDIKCAAQgAQQhwIQFDIFCAAQgAQyBAgAEEMyBQgAEIAEMgQIABBDMgUIABCABEoECEEYAEoECEYYAFAAWABgzwFoAHABeACAAW2IAW2SAQMwLjGYAQCgAQKgAQHAAQE&sclient=gws-wiz-serp"
                }
            };

            return glasses;
        }
    }
}