using Microsoft.EntityFrameworkCore;
using SalesOrders.Context;
using SalesOrders.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesOrders.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        protected AppDbContext _context;

        public PedidoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Pedido> GetAll()
        {
            return _context.Pedidos.Include(x => x.Cliente)
                .Include(x => x.ItensPedidos)
                .ToList();
        }
    }
}
