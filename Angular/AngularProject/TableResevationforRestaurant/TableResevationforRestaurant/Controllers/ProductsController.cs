using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;
using TableResevationforRestaurant.Repository.product_details;

namespace TableResevationforRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly Iproduct _context;

        public ProductsController(Iproduct context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.GetProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.GetProduct(id);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<Product>> PutProduct(int id, Product product)
        {
            return await _context.PutProduct(id, product);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<Product>>> PostProduct(Product product)
        {
            return await _context.PostProduct(product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<List<Product>> DeleteProduct(int id)
        {
            return await _context.DeleteProduct(id);
        }

        [HttpGet("menu")]
        public async Task<List<Product>> GetStarters(int id)
        {
            return await _context.GetStarters(id);
        }
        
    }
}
