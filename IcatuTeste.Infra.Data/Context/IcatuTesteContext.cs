using IcatuTeste.Domain.Models;
using IcatuTeste.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace IcatuTeste.Infra.Data.Context
{
    public class IcatuTesteContext : DbContext
    {
        public IcatuTesteContext(DbContextOptions<IcatuTesteContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

