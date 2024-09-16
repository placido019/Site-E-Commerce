using Microsoft.EntityFrameworkCore;
using Site_E_Commerce.models;
using System.Collections;

namespace Site_E_Commerce
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }

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

        public ICollection <Produto> Produtos { get; set; }

    }

}
