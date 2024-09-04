using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sep2024.Domain.Models.Entities;

namespace sep2024.Infraestructure.General.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("producto", "dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombre).HasColumnName("nombre");
            builder.Property(x => x.Precio).HasColumnName("precio");
            builder.Property(x => x.State).HasColumnName("state");
        }
    }
}
