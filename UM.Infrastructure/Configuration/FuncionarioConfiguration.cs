using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UM.Domain.DBModel;

namespace UM.Infrastructure.Configuration
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Foto)
                .HasMaxLength(100);
            builder.Property(x => x.RG)
                .HasMaxLength(100);
        }
    }
}
