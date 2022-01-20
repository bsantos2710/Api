using Microsoft.EntityFrameworkCore;
using ApiYouTube.Models;
using System;

namespace ApiYouTube.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categorys { get; set; }

        internal object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
