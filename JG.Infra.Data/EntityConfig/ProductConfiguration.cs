using JG.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace JG.Infra.Data.EntityConfig
{
    public class ProductConfiguration :  EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);

            Property(p => p.Description)
                .IsOptional()
                .HasMaxLength(150);

            Property(p => p.Price)
                .IsRequired()
                .HasColumnType("money");
        }
    }
}
