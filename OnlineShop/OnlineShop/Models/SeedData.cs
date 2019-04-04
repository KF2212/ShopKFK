using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Models;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OnlineShopContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OnlineShopContext>>()))
            {
                
                //if (context.Products.Any())
                //{
                //    return;   
                //}

                context.Products.AddRange(
                    new Products
                    {
                        Name = "Kurtka",
                        Description = "Zimowa",
                        Price = 120
                    },
                    new Products
                    {
                        Name = "Kurtka",
                        Description = "Wiosenna",
                        Price = 120
                    },
                    new Products
                    {
                        Name = "Kurtka",
                        Description = "Jesienna",
                        Price = 120
                    },
                    new Products
                    {
                        Name = "Kurtka",
                        Description = "Letnia",
                        Price = 120
                    },
                    new Products
                    {
                        Name = "Spodnie",
                        Description = "Zimowe",
                        Price = 120
                    },
                    new Products
                    {
                        Name = "Spodnie",
                        Description = "Letnie",
                        Price = 120
                    }
                );
                context.SaveChanges();
            }
        }
    }
}