using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class CatalogContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public CatalogContext():base("name=DefaultConnection")
        {

        }
    }
}
