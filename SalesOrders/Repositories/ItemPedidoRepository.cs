using Microsoft.EntityFrameworkCore;
using SalesOrders.Context;
using SalesOrders.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesOrders.Repositories
{
    public class ItemPedidoRepository : Repository<ItemPedido>, IItemPedidoRepository
    {
        protected AppDbContext _context;
        public ItemPedidoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<ItemPedido> GetAll()
        {
            return _context.ItensPedidos.Include(x => x.Pedido)
                .Include(x => x.Produto)
                .ToList();
        }
    }
}
