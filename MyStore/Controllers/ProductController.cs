using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using MyStore.Services.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public ProductController(IStoreService storeService) =>
            _storeService = storeService;

        // GET: api/<ProductController>
        [HttpGet]
        public IQueryable<Product> Get() => _storeService.GetAllProducts();
      
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id) => await _storeService.GetProductByIdAsync(id);
        
        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            var result = await _storeService.AddProduct(product);

            return Ok(result);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<ActionResult> Put(Product product)
        {
            await _storeService.UpdateProductAsync(product);

            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _storeService.DeleteProductAsync(id);

            return Ok(result);
        }
    }
}