using SalesOrders.Context;

namespace SalesOrders.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProdutoRepository _produtoRepository;
        private IClienteRepository _clienteRepository;
        private IPedidoRepository _pedidoRepository;
        public IItemPedidoRepository _itemPedidoRepository;
        private AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IProdutoRepository ProdutoRepository
        {
            get
            {
                return _produtoRepository = _produtoRepository ?? new ProdutoRepository(_context);
            }
        }

        public IClienteRepository ClienteRepository
        {
            get
            {
                return _clienteRepository = _clienteRepository ?? new ClienteRepository(_context);
            }
        }
        public IPedidoRepository PedidoRepository
        {
            get
            {
                return _pedidoRepository = _pedidoRepository ?? new PedidoRepository(_context);
            }
        }

        public IItemPedidoRepository ItemPedidoRepository
        {
            get
            {
                return _itemPedidoRepository = _itemPedidoRepository ?? new ItemPedidoRepository(_context);
            }
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
