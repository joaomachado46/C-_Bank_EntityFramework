using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibrary1
{
    public class BankContext : DbContext
    {
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<TipoDeConta> TipoDeContas { get; set; }
        public DbSet<TitularConta> TitularContas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GIKVBL1B\\SQLEXPRESS;" +
                "Initial Catalog=BankDbRumos;Integrated Security=True");
        }
    }
}
