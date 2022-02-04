using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Services;
using System;
using System.Collections.Generic;

namespace SalesOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensPedidosController : ControllerBase
    {
        private readonly IItemPedidoService _itemPedidoService;

        public ItensPedidosController(IItemPedidoService itemPedidoService)
        {
            _itemPedidoService = itemPedidoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemPedido>> findAll()
        {
            return _itemPedidoService.findAll();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<ItemPedido> save([FromBody] ItemPedidoDTO itempedidoDTO)
        {
            return _itemPedidoService.save(itempedidoDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult deleteItem(int id)
        {
            try
            {
                _itemPedidoService.deleteItem(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest("Mensagem: " + e);
            }
        }
    }
}
