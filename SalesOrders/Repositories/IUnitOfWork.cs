namespace SalesOrders.Repositories
{
    public interface IUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        IClienteRepository ClienteRepository { get;  }
        IPedidoRepository PedidoRepository { get; }
        IItemPedidoRepository ItemPedidoRepository { get; }
        void Commit();
    }
}
