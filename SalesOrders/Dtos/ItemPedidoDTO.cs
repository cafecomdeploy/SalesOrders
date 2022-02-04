namespace SalesOrders.Dtos
{
    public class ItemPedidoDTO
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
    }
}
