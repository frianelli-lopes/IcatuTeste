using IcatuTeste.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IcatuTeste.Infra.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property(p => p.Id).UseSqlServerIdentityColumn();
        }
    }
}

//public int Id { get; set; }
//public string Nome { get; set; }
//public DateTime DataNascimento { get; set; }
//public string Sexo { get; set; }
//public string CPF { get; set; }
