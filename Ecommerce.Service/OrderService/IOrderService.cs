using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Service.OrderService
{
    public interface IOrderService
    {
        Task CreateAsyn(List<ProductDTO> entity);
        Task<List<Order>> GetAllAsync();
    }
}