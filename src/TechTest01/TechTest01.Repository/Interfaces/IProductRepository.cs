using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Entities;
using TechTest01.Interfaces;

namespace TechTest01.Repository.Interfaces
{
    public interface IProductRepository: IRepository<Product>
    {
        IEnumerable<Product> GetRandom(int count);
    }
}
