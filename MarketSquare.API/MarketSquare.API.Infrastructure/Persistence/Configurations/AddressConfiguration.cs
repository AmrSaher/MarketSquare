using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(x => x.Sreet)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.BuildingNumber)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(x => x.FloorNumber)
                .IsRequired();

            builder.Property(x => x.ApartmentNumber)
                .IsRequired();

            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Governorate)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.IsDefault)
                .IsRequired();

            builder.HasMany(a => a.Orders)
                .WithOne(o => o.Address)
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
