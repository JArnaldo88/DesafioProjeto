using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesafioProjeto.Models;

namespace DesafioProjeto.Data
{
    public class DesafioProjetoContext : DbContext
    {
        public DesafioProjetoContext (DbContextOptions<DesafioProjetoContext> options)
            : base(options)
        {
        }

        public DbSet<DesafioProjeto.Models.Produto> Produto { get; set; }
    }
}
