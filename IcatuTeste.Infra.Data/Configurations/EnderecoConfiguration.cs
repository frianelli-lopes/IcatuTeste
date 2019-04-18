using IcatuTeste.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IcatuTeste.Infra.Data.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Propriedades
            builder.Property(p => p.Id).UseSqlServerIdentityColumn();

            builder.Property(p => p.Rua).HasColumnType("varchar(70)").HasMaxLength(70).IsRequired();

            builder.Property(p => p.Numero).HasColumnType("varchar(10)").HasMaxLength(10).IsRequired();

            builder.Property(p => p.Complemento).HasColumnType("varchar(50)").HasMaxLength(50);

            builder.Property(p => p.Bairro).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();

            builder.Property(p => p.Cidade).HasColumnType("varchar(50)").HasMaxLength(50).IsRequired();

            builder.Property(p => p.UF).HasColumnType("char(2)").HasMaxLength(2).IsRequired();

            builder.Property(p => p.CEP).HasColumnType("varchar(9)").HasMaxLength(9).IsRequired();


            //Chaves
            builder.HasKey(p => p.Id).HasName("PK_Endereco");

            builder.HasOne(c => c.Cliente).WithMany(c => c.Enderecos).HasConstraintName("FK_Endereco_Cliente").HasForeignKey(p => p.IdCliente).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
