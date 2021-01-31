using System;
using System.Collections.Generic;
using TechTest01.Domain.Entities;
using TechTest01.Repository.Interfaces;
using System.Linq;

namespace TechTest01.Repository.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CatalogContext context):base(context)
        {
        }

        public IEnumerable<Product> GetRandom(int count)
        {
            return CatalogContext.Products.OrderBy(r => Guid.NewGuid()).Take(count);
        }

        public CatalogContext CatalogContext
        {
            get { return Context as CatalogContext; }
        }
    }
}
