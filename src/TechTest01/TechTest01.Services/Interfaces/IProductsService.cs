using System.Collections.Generic;
using TechTest01.Domain.Entities;
using TechTest01.Services.Dtos;

namespace TechTest01.Services.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
        IEnumerable<ProductDto> GetBySlug(string slug);
        IEnumerable<ProductDto> GetRandom(int count);
    }
}
