using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

namespace WebApplication5.App
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)  { }
        public DbSet<Data> Data { get; set; }
        public DbSet<Categories> Categories { get; set; }  
        public DbSet<Products> Products { get; set; }

    }
}
