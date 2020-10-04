using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace KoalaBeach.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            // as we just deleted all products this will re-populate the database
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Overalls",
                        Description = "Denim overalls and pant jacket",
                        Category = "Pants",
                        SubCategory = "Women",
                        Image = "pants_female_overalls.jpg",
                        Price = 115.60M
                    },
                    new Product
                    {
                        Name = "Pants",
                        Description = "Casual pants",
                        Category = "Pants",
                        SubCategory = "Women",
                        Image = "pants_female_pinkish.jpg",
                        Price = 65
                    },
                    new Product
                    {
                        Name = "Short Overalls",
                        Description = "Denim short overalls",
                        Category = "Pants",
                        SubCategory = "Women",
                        Image = "pants_female_short_overalls.jpg",
                        Sale = true,
                        Price = 78
                    },
                    new Product
                    {
                        Name = "Shorts",
                        Description = "Denim shorts",
                        Category = "Pants",
                        SubCategory = "Women",
                        Image = "pants_female_shorts.jpg",
                        Price = 44
                    },
                    new Product
                    {
                        Name = "Jeans",
                        Description = "Long pants with crinkled denim",
                        Category = "Pants",
                        SubCategory = "Men",
                        Image = "pants_men_creased_jeans.jpg",
                        Price = 89
                    },
                    new Product
                    {
                        Name = "Pants",
                        Description = "Soft denim straight leg pants",
                        Category = "Pants",
                        SubCategory = "Men",
                        Image = "pants_men_grey.jpg",
                        Sale = true,
                        Price = 55
                    },
                    new Product
                    {
                        Name = "Dance Pants",
                        Description = "Gold patterned hiphop or modern dance pants",
                        Category = "Pants",
                        SubCategory = "Men",
                        Image = "pants_men_hiphop.jpg",
                        Price = 72
                    },
                    new Product
                    {
                        Name = "Sports Pants",
                        Description = "Trendy stretch pants for sport and exercise",
                        Category = "Pants",
                        SubCategory = "Men",
                        Image = "pants_men_sport.jpg",
                        Price = 50.50M
                    },
                    new Product
                    {
                        Name = "Converse",
                        Description = "Traditional style converse shoes",
                        Category = "Shoes",
                        SubCategory = "Men",
                        Image = "shoes_converse.jpg",
                        Price = 95
                    },
                    new Product
                    {
                        Name = "HipKick",
                        Description = "low white patterened shoes",
                        Category = "Shoes",
                        SubCategory = "Men",
                        Image = "shoes_hipkick.jpg",
                        Price = 87
                    },
                    new Product
                    {
                        Name = "National Graphic",
                        Description = "National Geographic walking shoes",
                        Category = "Shoes",
                        SubCategory = "Men",
                        Sale = true,
                        Image = "shoes_natgeo.jpg",
                        Price = 56
                    },
                    new Product
                    {
                        Name = "Groovy Green",
                        Description = "Lowset green canvas shoes",
                        Category = "Shoes",
                        SubCategory = "Men",
                        Image = "shoes_scott-kelly.jpg",
                        Price = 37.95M
                    },
                    new Product
                    {
                        Name = "Suit Jacket",
                        Description = "Traditional black suit jacket",
                        Category = "Tops",
                        SubCategory = "Men",
                        Image = "top_men_jacket.jpg",
                        Price = 150
                    },
                    new Product
                    {
                        Name = "Leather Jacket",
                        Description = "Soft brown leather jacket",
                        Category = "Tops",
                        SubCategory = "Men",
                        Image = "top_men_leather.jpg",
                        Price = 220
                    },
                    new Product
                    {
                        Name = "Parker",
                        Description = "Casual parker for everyday wear",
                        Category = "Tops",
                        SubCategory = "Men",
                        Image = "top_men_parker.jpg",
                        Price = 110
                    },
                    new Product
                    {
                        Name = "Rain Jacket",
                        Description = "Light weight water proof jacket",
                        Category = "Tops",
                        SubCategory = "Men",
                        Image = "top_men_rain.jpg",
                        Sale = true,
                        Price = 37.80M
                    },
                    new Product
                    {
                        Name = "Camouflage Jacket",
                        Description = "Soft everyday camouflage style jacket",
                        Category = "Tops",
                        SubCategory = "Women",
                        Image = "top_women_camaouflage.jpg",
                        Price = 158
                    },
                    new Product
                    {
                        Name = "Camisole",
                        Description = "Varied color camasole tops",
                        Category = "Tops",
                        SubCategory = "Women",
                        Image = "top_women_cami.jpg",
                        Price = 99
                    },
                    new Product
                    {
                        Name = "Open Weave Top",
                        Description = "Open weave wollen croched top",
                        Category = "Tops",
                        SubCategory = "Women",
                        Image = "top_women_lace.jpg",
                        Price = 62
                    },
                    new Product
                    {
                        Name = "Parker",
                        Description = "Thick parker for winter",
                        Category = "Tops",
                        SubCategory = "Women",
                        Image = "top_women_parker.jpg",
                        Price = 175
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
