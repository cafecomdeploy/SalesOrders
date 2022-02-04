using Microsoft.EntityFrameworkCore;
using SalesOrders.Context;
using SalesOrders.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesOrders.Repositories
{
    public class ClienteRepository : Repository<Cliente> , IClienteRepository
    {

        protected AppDbContext _context;

        public ClienteRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Cliente GetID(int id)
        {
            return _context.Clientes.Include(x => x.Pedidos).Where(x => x.ClienteId == id).FirstOrDefault();

        }
    }
}
