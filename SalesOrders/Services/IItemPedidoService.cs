using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using System.Collections.Generic;

namespace SalesOrders.Services
{
    public interface IItemPedidoService
    {
        ActionResult<IEnumerable<ItemPedido>> findAll();
        ActionResult<ItemPedido> save(ItemPedidoDTO itemPedidoDTO);
        void deleteItem(int id);
    }
}
