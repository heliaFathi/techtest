using System;
using System.Collections.Generic;
using TechTest01.Domain.Entities;
using TechTest01.Repository.Interfaces;

namespace TechTest01.Repository.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CatalogContext context):base(context)
        {
            
        }
    }
}
