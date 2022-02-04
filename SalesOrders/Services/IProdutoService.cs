using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using System.Collections.Generic;

namespace SalesOrders.Services
{
    public interface IProdutoService
    {
        ActionResult<IEnumerable<ProdutoDTO>> findAll();
        ActionResult<Produto> save(ProdutoDTO produtoDTO);
        ActionResult<Produto> findById(int id);
    }
}
