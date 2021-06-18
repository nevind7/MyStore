using Domain.Models;

using Microsoft.EntityFrameworkCore.ChangeTracking;

using MyStore.Contexts;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Services.Products
{
    // Repo/service...
    public partial class StoreService : IStoreService
    {
        private readonly MyStoreDbContext _context;

        public StoreService(MyStoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> GetAllProducts() => _context.Products;

        public async Task<Product> AddProduct(Product product)
        {
            EntityEntry<Product> productEntityEntry = await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return productEntityEntry.Entity;
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            var productEntityEntry = _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return productEntityEntry.Entity;
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            var product = await GetProductByIdAsync(productId);

            _context.Remove(product);

            var result = await _context.SaveChangesAsync();

            return result == 1;
        }

        
    }
}