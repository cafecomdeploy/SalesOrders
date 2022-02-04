using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Models.Enums;
using System.Collections.Generic;

namespace SalesOrders.Services
{
    public interface IPedidoService
    {
        ActionResult<IEnumerable<Pedido>> findAll();
        ActionResult<Pedido> save(PedidoDTO pedidoDTO);
        void alteraStatus(int id, PedidoStatus pedidoStatus);
    }
}
