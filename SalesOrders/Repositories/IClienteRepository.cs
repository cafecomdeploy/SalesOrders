using SalesOrders.Models;
using System.Collections.Generic;

namespace SalesOrders.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente GetID(int id);
    }
}
