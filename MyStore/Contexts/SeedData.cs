using Domain.Models;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace MyStore.Contexts
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MyStoreDbContext context = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<MyStoreDbContext>();

            if (!context.Products.Any())
            {
                context.Products.AddRange(new Product()
                {
                    Name = "T-Shirt",
                    Description = "Blue, X-Large",
                    Price = 19.99m
                },
                    new Product()
                    {
                        Name = "Jeans",
                        Description = "Blue, X-Large",
                        Price = 49.99m
                    },
                    new Product()
                    {
                        Name = "Sunglasses",
                        Description = "Black",
                        Price = 9.99m
                    },
                    new Product()
                    {
                        Name = "Socks",
                        Description = "Ankle socks",
                        Price = 4.99m
                    },
                    new Product()
                    {
                        Name = "Sweater",
                        Description = "Red, X-Large",
                        Price = 69.99m
                    });

                context.SaveChanges();
            }
        }
    }
}