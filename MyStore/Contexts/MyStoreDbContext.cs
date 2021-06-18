using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MyStore.Contexts
{
    public class MyStoreDbContext : DbContext
    {
        public MyStoreDbContext(DbContextOptions<MyStoreDbContext> options)
                                : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}