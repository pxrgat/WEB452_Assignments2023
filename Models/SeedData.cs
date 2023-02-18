using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Soaps.Data;
using System;
using System.Linq;

namespace Soaps.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SoapsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SoapsContext>>()))
            {
                // Look for any movies.
                if (context.Soap.Any())
                {
                    return;   // DB has been seeded
                }

                context.Soap.AddRange(
                    new Soap
                    {
                        Brand = "Axe",
                        Category ="Male",
                        Fragrance = "Mint",
                        Forms = "bar soap",
                        Price = 6,
                        Rating = 5
                    },

                    new Soap
                     {
                         Brand = "Lux",
                         Category = "Male",
                         Fragrance = "Rose",
                         Forms = "soap",
                         Price = 7,
                         Rating = 4
                     },

                    new Soap
                    {
                        Brand = "Dettol",
                        Category = "Both",
                        Fragrance = "Orange",
                        Forms = "bar soap",
                        Price = 8,
                        Rating = 2
                    },
                     new Soap
                     {
                         Brand = "Pears",
                         Category = "Both",
                         Fragrance = "Mint",
                         Forms = "bar soap",
                         Price = 6,
                         Rating = 5
                     },
                     new Soap
                      {
                          Brand = "Lifebuoy",
                          Category = "Both",
                          Fragrance = "Lemon",
                          Forms = "bar soap",
                          Price = 5,
                          Rating = 5
                      },
                     new Soap
                     {
                         Brand = "Hamam",
                         Category = "Male",
                         Fragrance = "Neem",
                         Forms = "bar soap",
                         Price = 6,
                         Rating = 2
                     },
                     new Soap
                     {
                         Brand = "Medimax",
                         Category = "Both",
                         Fragrance = "Mint",
                         Forms = "bar soap",
                         Price = 5,
                         Rating = 4
                     },
                     new Soap
                     {
                         Brand = "Santoor",
                         Category = "Female",
                         Fragrance = "Rose",
                         Forms = "bar soap",
                         Price = 7,
                         Rating = 4
                     },
                     new Soap
                     {
                         Brand = "Himalaya",
                         Category = "Female",
                         Fragrance = "Mint",
                         Forms = "bar soap",
                         Price = 7,
                         Rating = 4
                     },
                     new Soap
                     {
                         Brand = "Yardley",
                         Category = "Both",
                         Fragrance = "Mint",
                         Forms = "Liquid soap",
                         Price = 6,
                         Rating = 5
                     }
                );
                context.SaveChanges();
            }
        }
    }
}