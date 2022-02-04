using SalesOrders.Models;
using System.Collections.Generic;

namespace SalesOrders.Repositories
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        List<Pedido> GetAll();
    }
}
