using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMarttech.Models;

namespace TesteMarttech.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Testemvc;Integrated Security=True");

        }

        public DbSet<TesteMarttech.Models.Cliente> Cliente { get; set; }

        public DbSet<TesteMarttech.Models.Endereco> Endereco { get; set; }
    }
}
