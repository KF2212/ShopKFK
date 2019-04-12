using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Controllers;
using OnlineShop.Models;
using OnlineShop.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class LoginDbContext : IdentityDbContext<User, ApplicationRole, string>
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options)
        {

        }
    }
}
