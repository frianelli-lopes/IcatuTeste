using IcatuTeste.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace IcatuTeste.Infra.Data.Context
{
    public class IcatuTesteContext : DbContext
    {
        public IcatuTesteContext(DbContextOptions<IcatuTesteContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AcompanhamentoConfiguration());
            modelBuilder.ApplyConfiguration(new AnexoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

