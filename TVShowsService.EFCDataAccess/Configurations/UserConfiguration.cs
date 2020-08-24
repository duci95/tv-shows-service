using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TVShowsService.Domain;

namespace TVShowsService.EFCDataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(512);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(70);
            builder.Property(u => u.Username).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Token).IsRequired().HasMaxLength(512);

            builder.HasIndex(u => u.Username).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(u => u.IsDeleted).HasDefaultValue(false);

            builder.Property(u => u.IsActive).HasDefaultValue(false);
            builder.Property(u => u.IsBanned).HasDefaultValue(false);
        }
    }
}