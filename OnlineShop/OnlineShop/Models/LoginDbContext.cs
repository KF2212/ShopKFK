using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class LoginDbContext : IdentityDbContext<User>
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = LoginDemo; Integrated Security = True;Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True;ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
