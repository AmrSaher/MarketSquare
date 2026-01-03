using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendors");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(x => x.LogoUrl)
                .IsRequired()
                .HasMaxLength(2048);

            builder.HasMany(v => v.Products)
                .WithOne(p => p.Vendor)
                .HasForeignKey(p => p.VendorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(v => v.Orders)
                .WithOne(o => o.Vendor)
                .HasForeignKey(o => o.VendorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
