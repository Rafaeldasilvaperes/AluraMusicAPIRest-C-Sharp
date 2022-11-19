using AluraMusicAPIRest.Models;
using Microsoft.EntityFrameworkCore;


namespace AluraMusicAPIRest.DataContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        {
        }
        
        public DbSet<ProductModel> Product { get; set; }
    }
}
