using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class SubOrderConfiguration : IEntityTypeConfiguration<SubOrder>
    {
        public void Configure(EntityTypeBuilder<SubOrder> builder)
        {
            builder.ToTable("SubOrders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TotalAmount)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(x => x.Status)
                .IsRequired();

            builder.HasMany(so => so.Items)
                .WithOne(oi => oi.SubOrder)
                .HasForeignKey(oi => oi.SubOrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
