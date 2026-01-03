using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItems");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
