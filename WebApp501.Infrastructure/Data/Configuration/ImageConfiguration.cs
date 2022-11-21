using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApp501.Infrastructure.Data.Entities;

namespace WebApp501.Infrastructure.Data.Configuration
{
    internal class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder
                .HasData(CreateImages());
        }

        private List<Image> CreateImages()
        {
            var images = new List<Image>()
                {
                new Image()
                {
                    Id = 1,
                    ImageUrl = "https://www.google.com/search?q=Cocktail+Gauguin&hl=en&sxsrf=ALiCzsYZijqseouEFjzKEYTw-66_8uzpsA%3A1668594209334&ei=Ibp0Y5P1E_GTxc8PpdmT8AI&ved=0ahUKEwjTifzovbL7AhXxSfEDHaXsBC4Q4dUDCA8&uact=5&oq=Cocktail+Gauguin&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIECCMQJzIGCAAQFhAeOgoIABBHENYEELADOgcIABCwAxBDOg0IABDkAhDWBBCwAxgBOhIILhDHARDRAxDIAxCwAxBDGAI6FQguEMcBENEDENQCEMgDELADEEMYAjoECAAQQzoKCC4QxwEQ0QMQQzoQCC4QgAQQhwIQxwEQ0QMQFDoFCAAQgAQ6CwguEIAEEMcBENEDOgcILhDUAhBDOggILhCABBDUAjoKCC4Q1AIQgAQQQzoICAAQgAQQyQM6DgguEIAEEMcBEK8BEMsBSgQIQRgASgQIRhgBUNIJWNQmYKUuaARwAXgAgAGNAYgBmQmSAQQwLjEwmAEAoAEBoAECyAERwAEB2gEGCAEQARgJ2gEGCAIQARgI&sclient=gws-wiz-serp"
                },
                new Image()
                {
                    Id = 2,
                    ImageUrl = "https://www.google.com/search?q=sex+on+the+beach+cocktail&hl=en&sxsrf=ALiCzsbVoUJDMmVhnd712I2_OEi4zn8HKQ%3A1668597389724&ei=jcZ0Y8DaK7CWxc8P7pS3uAs&gs_ssp=eJzj4tLP1TcwKsqotCg2YHRg8JIsTq1QyM9TKMlIVUhKTUzOUEjOT84uSczMAQAB0Q0_&oq=Sex+on+the+Beach+&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgAMgcILhCABBBDMgQIABBDMggILhCABBDLATIICAAQgAQQywEyBQgAEIAEMgQIABBDMgQIABBDMgUIABCABDIFCAAQgAQyCggAEIAEEIcCEBRKBAhBGABKBAhGGABQAFi5A2DBIGgAcAF4AIABnQGIAY4CkgEDMC4ymAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Image()
                {
                    Id = 3,
                    ImageUrl = "https://www.google.com/search?q=rhett+butler+cocktail&hl=en&sxsrf=ALiCzsbUCF-euUThMys6PTAiPP0xK4V37w%3A1668595185273&ei=8b10Y6ydEJqRxc8Pzo2z-As&oq=Rhett+Butler&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAxgBMgUIABCABDIKCAAQgAQQhwIQFDIFCAAQgAQyBQguEIAEMgUILhCABDIFCAAQgAQyBQgAEIAEMgUIABCABDILCC4QgAQQxwEQrwEyBQgAEIAESgQIQRgASgQIRhgAUABYAGCfF2gAcAF4AIABqQKIAakCkgEDMi0xmAEAoAECoAEBwAEB&sclient=gws-wiz-serp"
                },
                new Image()
                {
                    Id = 4,
                    ImageUrl = "https://www.google.com/search?q=Cheshire+Cat+Cocktail&sxsrf=ALiCzsYnvGR_m4i19I70GL1_6ctyPC0kCg%3A1668601527470&ei=t9Z0Y62oHP-Pxc8PoaufkAM&ved=0ahUKEwjt38OK2bL7AhX_R_EDHaHVBzIQ4dUDCA8&uact=5&oq=Cheshire+Cat+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMggIABAWEB4QDzIFCAAQhgMyBQgAEIYDMgUIABCGAzIFCAAQhgMyBQgAEIYDOgoIABBHENYEELADOgcIABCwAxBDOg0IABDkAhDWBBCwAxgBOgwILhDIAxCwAxBDGAI6DwguENQCEMgDELADEEMYAjoECAAQQzoICAAQgAQQywE6BQghEKABSgQIQRgASgQIRhgBUJcBWN8qYN0uaANwAXgAgAGTAYgB8gmSAQQxLjEwmAEAoAEByAETwAEB2gEGCAEQARgJ2gEGCAIQARgI&sclient=gws-wiz-serp"
                },
                new Image()
                {
                    Id = 5,
                    ImageUrl = "https://www.google.com/search?q=Mexicana+Cocktail&sxsrf=ALiCzsbqImQPN1VjWrRYrgZM5Fnv2oYZ3Q%3A1668601536059&ei=wNZ0Y5WXA9uIxc8P_c2z4AY&ved=0ahUKEwiV98-O2bL7AhVbRPEDHf3mDGwQ4dUDCA8&uact=5&oq=Mexicana+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyCAgAEIAEEMsBMggIABAWEB4QCjIGCAAQFhAeMgYIABAWEB4yCAgAEBYQHhAKMgYIABAWEB4yCggAEBYQHhAPEAoyCAgAEBYQHhAKMgYIABAWEB46BQguEIAEOgUIIRCgAToKCAAQgAQQhwIQFDoHCAAQgAQQCjoICAAQFhAeEA9KBAhBGABKBAhGGABQAFioNWCrN2gCcAF4AIABigGIAfgJkgEEMC4xMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Image()
                {
                    Id = 6,
                    ImageUrl = "https://www.google.com/search?q=Slippery+Nipple+Cocktail&sxsrf=ALiCzsZ4y_0nwTU0wFWwU8KO1G0xUdBsSA%3A1668601931172&ei=S9h0Y9b_CYqqxc8P68qFyA4&ved=0ahUKEwiW0YPL2rL7AhUKVfEDHWtlAekQ4dUDCA8&uact=5&oq=Slippery+Nipple+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIKCC4QgAQQhwIQFDIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIFCAAQhgMyBQgAEIYDOgYIABAHEB46BQguEIAEOgYIABAIEB5KBAhBGABKBAhGGABQAFgAYP4haABwAXgAgAGjAogBpgOSAQUwLjEuMZgBAKABAqABAcABAQ&sclient=gws-wiz-serp"
                },
                new Image()
                {
                    Id = 7,
                    ImageUrl = "https://www.google.com/search?q=Bitter+Sweet+Cocktail&sxsrf=ALiCzsYtnnGfQTc9sgKc8-ouqUjsQ4hILg%3A1668602388689&ei=FNp0Y7PUKc-Xxc8P0MOomA4&ved=0ahUKEwizrpil3LL7AhXPS_EDHdAhCuMQ4dUDCA8&uact=5&oq=Bitter+Sweet+Cocktail&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIGCAAQBxAeMgUIABCABDIFCAAQgAQyCAgAEAgQHhAKMgYIABAIEB4yBQgAEIYDMgUIABCGAzoLCAAQBxAeELADEAo6BwgAELADEEM6CAgAEIAEELADOgsIABCABBCwAxDLAToJCAAQCBAeELADOgwILhDIAxCwAxBDGAE6DwguENQCEMgDELADEEMYAUoECEEYAUoECEYYAVDHggtYx4ILYJ6MC2gBcAB4AIABfIgBfJIBAzAuMZgBAKABAqABAcgBEsABAdoBBggBEAEYCA&sclient=gws-wiz-serp"
                }
                };

            return images;
        }
    }
}