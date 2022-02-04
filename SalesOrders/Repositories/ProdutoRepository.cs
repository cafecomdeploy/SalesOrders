using SalesOrders.Context;
using SalesOrders.Models;

namespace SalesOrders.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        protected AppDbContext _context;

        public ProdutoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
