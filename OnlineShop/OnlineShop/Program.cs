using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OnlineShop.Models;
using OnlineShop.Models.DomainModels;

namespace OnlineShop
{
    public class Program
    {
        public static List<ProductViewModel> Products { get; set; }

        private static void PopulateProduct()
        {
            Products = new List<ProductViewModel>();
            Products.Add(new ProductViewModel
            {
                Name = "Jeansy",
                Size = Helpers.Sizes.M,
                Description = "Lorem ipsum",
                Price = 159,
                Id = 1,
                Color = Helpers.Colors.Black
            });
            Products.Add(new ProductViewModel
            {
                Name = "Top",
                Size = Helpers.Sizes.S,
                Description = "Lorem ipsum",
                Price = 79,
                Id = 2,
                Color = Helpers.Colors.White
            });
            Products.Add(new ProductViewModel
            {
                Name = "Buty",
                Size = Helpers.Sizes.L,
                Description = "Lorem ipsum",
                Price = 379,
                Id = 3,
                Color = Helpers.Colors.White
            });
        }

        public static void Main(string[] args)
        {
            PopulateProduct();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
