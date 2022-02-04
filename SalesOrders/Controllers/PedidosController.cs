using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Models.Enums;
using SalesOrders.Services;
using System;
using System.Collections.Generic;

namespace SalesOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Pedido>> GetAll()
        {
            return _pedidoService.findAll();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Pedido> save([FromBody] PedidoDTO pedidoDTO)
        {
            return _pedidoService.save(pedidoDTO);
        }

        [HttpPut("{id}/{pedidoStatus}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult alteraStatusPedido(int id, PedidoStatus pedidoStatus)
        {
            try
            {
               _pedidoService.alteraStatus(id, pedidoStatus);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest("Mensagem: " + e);
            }
        }
    }
}
