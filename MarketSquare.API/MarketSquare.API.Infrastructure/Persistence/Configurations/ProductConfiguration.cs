using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(5000);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(x => x.Stock)
                .IsRequired();

            builder.HasMany(p => p.Categories)
                .WithMany(c => c.Products);

            builder.HasMany(p => p.Images)
                .WithOne(pi => pi.Product)
                .HasForeignKey(pi => pi.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
