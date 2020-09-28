using Ecommerce.Infrastructure.UnitOfWork;
using Ecommerce.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Domain.Entity;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Ecommerce.Domain.DTO;

namespace Ecommerce.Service.Productervice
{
    public class Productervice : IProductervice
    {
        private readonly IRepository<Product> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Productervice(
            IRepository<Product> repository,
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsyn(ProductDTO dto)
        {
            try
            {
                var entity = _mapper.Map<Product>(dto);
                _repository.Insert(entity);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task UpdateAsyn(ProductDTO dto)
        {
            var entity = _mapper.Map<Product>(dto);
            _repository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsyn(ProductDTO dto)
        {
            var entity = _mapper.Map<Product>(dto);
            _repository.Delete(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ProductDTO>> GetAllAsync()
        {
            var Product = await _repository.Queryable().ToListAsync();
            return _mapper.Map<List<ProductDTO>>(Product);
        }
    }
}
