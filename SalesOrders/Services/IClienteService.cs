using Microsoft.AspNetCore.Mvc;
using SalesOrders.Dtos;
using SalesOrders.Models;
using SalesOrders.Models.Enums;

namespace SalesOrders.Services
{
    public interface IClienteService
    {
        Cliente GetID(int id);
        ActionResult<Cliente> save(ClienteDTO clienteDTO);
        ActionResult<bool> verificaCredito(int id);
        Cliente alteraStatus(int id, ClienteStatus status);
    }
}
