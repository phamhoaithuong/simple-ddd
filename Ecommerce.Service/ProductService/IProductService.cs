using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Service.Productervice
{
    public interface IProductervice
    {
        Task CreateAsyn(ProductDTO entity);
        Task DeleteAsyn(ProductDTO entity);
        Task<List<ProductDTO>> GetAllAsync();
        Task UpdateAsyn(ProductDTO entity);
    }
}