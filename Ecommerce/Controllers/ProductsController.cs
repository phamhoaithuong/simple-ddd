using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Entity;
using Ecommerce.Service.Productervice;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductervice _Productervice;
        public ProductController(IProductervice Productervice)
        {
            _Productervice = Productervice;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<List<ProductDTO>> GetAsync()
        {
            return await _Productervice.GetAllAsync();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductDTO value)
        {
            _Productervice.CreateAsyn(value);
        }

        // PUT api/<ProductController>
        [HttpPut()]
        public async Task PutAsync([FromBody] ProductDTO value)
        {
            await _Productervice.UpdateAsyn(value);
        }
    }
}
