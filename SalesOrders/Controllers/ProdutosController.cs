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
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;


        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<ProdutoDTO>> Get()
        {
            try
            {
                return _produtoService.findAll();
            }
            catch (Exception e)
            {
                return BadRequest("Mensagem: " + e);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Produto> save([FromBody] ProdutoDTO produtoDTO)
        {

            return _produtoService.save(produtoDTO);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Produto> GetById(int id)
        {
            try
            {
                return _produtoService.findById(id);
            }catch(Exception e)
            {
                return BadRequest("Message : " + e);
            }
        }

    }
}
