using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Models.Enums;
using SalesOrders.Services;
using System;
using System.Net.Http;

namespace SalesOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Cliente> save([FromBody] ClienteDTO clienteDTO)
        {
            return _clienteService.save(clienteDTO);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<bool> verificaCredito(int id)
        {
            try
            {
                return _clienteService.verificaCredito(id);
            }
            catch(Exception e)
            {
                return BadRequest("Messaage: " + e.Message);
            }
        }

        [HttpGet("{id}/clienteId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Cliente> FindById(int id)
        {
            try
            {
                return _clienteService.GetID(id);
            }
            catch (Exception e)
            {
                return BadRequest("Messaage: " + e.Message);
            }
        }

        [HttpPut("{id}/{status}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<Cliente> alteraStatus(int id, ClienteStatus status)
        {
            try
            {
                return _clienteService.alteraStatus(id, status);
            }
            catch (Exception e)
            {
                return BadRequest("Messaage: " + e.Message);
            }
        }
    }
}
