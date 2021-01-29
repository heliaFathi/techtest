using AutoMapper;
using TechTest01.Domain.Entities;
using TechTest01.Services.Dtos;

namespace TechTest01.Services.Common
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, ProductDto>();
           
        }
    }
}
