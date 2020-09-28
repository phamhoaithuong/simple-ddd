using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Entity;
using Ecommerce.Infrastructure.Repository;
using Ecommerce.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _ordersRepository;
        private readonly IRepository<OrderDetail> _orderDetailsRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(
            IRepository<Order> ordersRepository,
            IRepository<OrderDetail> orderDetailsRepository,
            IUnitOfWork unitOfWork
            )
        {
            _ordersRepository = ordersRepository;
            _orderDetailsRepository = orderDetailsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsyn(List<ProductDTO> entity)
        {
            var order = new Order();
            order.Id = Guid.NewGuid().ToString();
            order.OrderDate = DateTime.Now;
            _ordersRepository.Insert(order);

            entity.ForEach(e =>
            {
                var detail = new OrderDetail() { Id= Guid.NewGuid().ToString(),  OrderId = order.Id, ProductId = e.Id, Quantity = e.Quantity };
                _orderDetailsRepository.Insert(detail);
            });
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _ordersRepository.Queryable().Include(o => o.OrderDetail).ToListAsync();
        }
    }
}
