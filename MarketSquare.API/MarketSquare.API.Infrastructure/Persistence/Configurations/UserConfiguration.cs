using MarketSquare.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarketSquare.API.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.HasOne(u => u.Vendor)
                .WithOne(v => v.User)
                .HasForeignKey<Vendor>(v => v.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
