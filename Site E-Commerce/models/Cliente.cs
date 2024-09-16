namespace Site_E_Commerce.models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public ICollection<Pedido> pedidos { get; set; }

    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double preco { get; set; }
        public int estoque { get; set; }
        public ICollection<Pedido> pedidos { get; set; }
    }

    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }

        //Lembrar de relacionar certo no DB
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; } //um pedido pertence a um cliente

        public ICollection<Produto> Produtos { get; set; }

    }

    public class ItemPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }

        //Relacionando...
        public int PedidoId {get; set; }
        public Pedido Pedido { get; set; } //Um item pertence a um pedido

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } //Um item refere-se a um produto!
    }
}
