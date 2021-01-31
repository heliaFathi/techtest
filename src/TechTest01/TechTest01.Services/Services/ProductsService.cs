using AutoMapper;
using System.Collections.Generic;
using TechTest01.Repository.Interfaces;
using TechTest01.Services.Dtos;
using TechTest01.Services.Interfaces;

namespace TechTest01.Services.Services
{
    public class ProductsService : IProductsService
    {
        private IMapper _mapper;
        private IUnitOfWork _uow;
        public ProductsService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public ProductDto GetById(int id)
        {
            var product = _uow.Products.SingleOrDefault(p => p.Id == id);
            return _mapper.Map<ProductDto>(product);
        }
        public IEnumerable<ProductDto> GetBySlug(string slug)
        {
            var product = _uow.Products.Find(p => p.Slug.Contains(slug));
            return _mapper.Map<IEnumerable<ProductDto>>(product);
        }
        public IEnumerable<ProductDto> GetAll()
        {
            var products = _uow.Products.GetAll();
            
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
        public IEnumerable<ProductDto> GetRandom(int count)
        {
            var products = _uow.Products.GetRandom(count);

            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
