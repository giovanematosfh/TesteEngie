using EstudoFullStack.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace EstudoFullStack.Infrastructure
{
    public class MyContext : DbContext
    {
        public DbSet<Usina> Usinas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=XPGGAMER;Initial Catalog=Engie;User Id=teste;password=12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }
}
