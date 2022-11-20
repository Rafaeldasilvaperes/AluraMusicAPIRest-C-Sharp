using AluraMusicAPIRest.Models;
using Microsoft.EntityFrameworkCore;


namespace AluraMusicAPIRest.Data

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<ProductModel> Product { get; set; }
}
