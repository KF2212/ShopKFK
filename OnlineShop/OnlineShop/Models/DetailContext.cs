using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class DetailContext:DbContext
    {
        public DetailContext(DbContextOptions<DetailContext> options) : base(options)
        {

        }
        public DetailContext()
        {

        }
        //public DbSet<Contact> Contacts { get;set; }
        public DbSet<SignUp> signUp { get;set; }
    }
}
