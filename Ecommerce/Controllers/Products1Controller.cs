//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Ecommerce.Domain.Entity;

//namespace Ecommerce.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class Product1Controller : ControllerBase
//    {
//        private readonly EcommerceContext _context;

//        public Product1Controller(EcommerceContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Product1
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
//        {
//            return await _context.Product.ToListAsync();
//        }

//        // GET: api/Product1/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Product>> GetProduct(int id)
//        {
//            var Product = await _context.Product.FindAsync(id);

//            if (Product == null)
//            {
//                return NotFound();
//            }

//            return Product;
//        }

//        // PUT: api/Product1/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutProduct(int id, Product Product)
//        {
//            if (id != Product.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(Product).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!ProductExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Product1
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<Product>> PostProduct(Product Product)
//        {
//            _context.Product.Add(Product);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetProduct", new { id = Product.Id }, Product);
//        }

//        // DELETE: api/Product1/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Product>> DeleteProduct(int id)
//        {
//            var Product = await _context.Product.FindAsync(id);
//            if (Product == null)
//            {
//                return NotFound();
//            }

//            _context.Product.Remove(Product);
//            await _context.SaveChangesAsync();

//            return Product;
//        }

//        private bool ProductExists(int id)
//        {
//            return _context.Product.Any(e => e.Id == id);
//        }
//    }
//}
