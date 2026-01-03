using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalAmount)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired();

            builder.HasMany(o => o.SubOrders)
                .WithOne(so => so.Order)
                .HasForeignKey(so => so.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
