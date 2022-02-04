using SalesOrders.Models;
using System.Collections.Generic;

namespace SalesOrders.Repositories
{
    public interface IItemPedidoRepository : IRepository<ItemPedido>
    {
        List<ItemPedido> GetAll();
    }
}
