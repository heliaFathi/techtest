using TechTest01.Repository.Interfaces;
using TechTest01.Repository.Repositories;

namespace TechTest01.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CatalogContext _context;
        public UnitOfWork(CatalogContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public IProductRepository Products { get;private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
