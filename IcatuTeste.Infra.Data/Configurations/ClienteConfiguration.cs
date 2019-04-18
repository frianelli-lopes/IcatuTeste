using IcatuTeste.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IcatuTeste.Infra.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //Propriedades
            builder.Property(p => p.Id).UseSqlServerIdentityColumn();

            builder.Property(p => p.Nome).HasColumnType("varchar(100)").HasMaxLength(100).IsRequired();

            builder.Property(p => p.Sexo).HasColumnType("char(1)").HasMaxLength(1).IsRequired();

            builder.Property(p => p.CPF).HasColumnType("varchar(11)").HasMaxLength(11).IsRequired();


            //Chaves
            builder.HasKey(p => p.Id).HasName("PK_Cliente");
        }
    }
}
