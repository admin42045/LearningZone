using _00_Basic.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Basic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private static List<Product> _products = new List<Product>
        {
            new Product(){ Id = 1, Name = "Laptop", Price = (double)1000.00m, Category = "Electronices" },
            new Product(){ Id = 2, Name = "Mobile", Price = (double)300.00m, Category ="Electronices"},
            new Product(){ Id = 3, Name = "Tablets", Price = (double)600.00m, Category = "Electronices"},
        };
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(_products);
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                return NotFound(new { Message = $"Prodcut with {id} not found!"});
            }
            return Ok(product);
        }

        //post/api/products
        [HttpPost]
        public ActionResult<Product> PostProduct([FromBody] Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult PutProduct(int id,[FromBody] Product updateProduct)
        {
            if(id != updateProduct.Id)
            {
                return BadRequest(new { Message = $"Id mismatch between route and body" });
            }
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if(existingProduct == null)
            {
                return NotFound(new { Message = $"product with {id} not found!!" });
            }

            // update the product properties
            existingProduct.Name = updateProduct.Name;
            existingProduct.Price = updateProduct.Price;
            existingProduct.Category = updateProduct.Category;

            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                return NotFound(new { Message = $"Proudct with {id} not found!" });
            }
            _products.Remove(product);
            return NoContent();
        }
    }
}
