using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class ProductDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> catagorys { get; set; }
    }
}