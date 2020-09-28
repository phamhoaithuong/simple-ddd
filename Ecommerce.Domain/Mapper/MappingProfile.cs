using AutoMapper;
using Ecommerce.Domain.DTO;
using Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Product, ProductDTO>().ForMember(x => x.Quantity, opt => opt.Ignore());
            CreateMap<ProductDTO, Product>();
        }
    }
}
