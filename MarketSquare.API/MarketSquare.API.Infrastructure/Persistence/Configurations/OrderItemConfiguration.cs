using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.XPath;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.Property(x => x.UnitPrice)
                .IsRequired();

            builder.HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
