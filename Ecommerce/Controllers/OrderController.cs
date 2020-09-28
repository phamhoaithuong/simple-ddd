using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Entity;
using Ecommerce.Service.OrderService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(
            IOrderService orderService
            )
        {
            _orderService = orderService;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IEnumerable<Order>> GetAsync()
        {
            return await _orderService.GetAllAsync();
        }    

        // POST api/<OrderController>
        [HttpPost]
        public async Task PostAsync([FromBody] List<ProductDTO> productDTOs )
        {
            await _orderService.CreateAsyn(productDTOs);
        }
    }
}
