using DesafioProjeto.Models;
using Microsoft.EntityFrameworkCore;
using static DesafioProjeto.Models.Produto;

namespace DesafioProjeto.Data
{
    public class AppDbContext
    {
        public class lAppDbContext : DbContext

        {
            //Acrescentei "l" para não ter conflito
            public lAppDbContext(DbContextOptions<lAppDbContext> options) : base(options)

            {

            }



            public DbSet<Produto> Produtos { get; set; }



            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                modelBuilder.Entity<Produto>()

                    .Property(p => p.Nome)

                        .HasMaxLength(80);



                modelBuilder.Entity<Produto>()

                    .Property(p => p.Preco)

                        .HasPrecision(10, 2);



                modelBuilder.Entity<Produto>()

                    .HasData(

                        new Produto { Id = 1, Nome = "Caderno", Preco = 7.95M, Estoque = 10 },

                        new Produto { Id = 2, Nome = "Borracha", Preco = 2.45M, Estoque = 30 },

                        new Produto { Id = 3, Nome = "Lápis", Preco = 1.50M, Estoque = 20 }

                    );

            }

        }
    }
}
