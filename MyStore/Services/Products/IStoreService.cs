using Domain.Models;

using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Services.Products
{
    public interface IStoreService
    {
        IQueryable<Product> GetAllProducts();

        Task<Product> AddProduct(Product product);

        Task<Product> GetProductByIdAsync(int productId);

        Task<Product> UpdateProductAsync(Product product);

        Task<bool> DeleteProductAsync(int productId);
    }
}