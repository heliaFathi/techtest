using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTest01.Repository.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository Products { get; }
        int Complete();
    }
}
