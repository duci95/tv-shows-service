using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TVShowsService.Domain;

namespace TVShowsService.EFCDataAccess.Configurations
{
    public class ShowConfiguration : IEntityTypeConfiguration<Show>
    {
        public void Configure(EntityTypeBuilder<Show> builder)
        {
            builder.Property(s => s.Dislikes).HasDefaultValue(0);
            builder.Property(s => s.Likes).HasDefaultValue(0);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.About).IsRequired();
            builder.Property(s => s.Body).IsRequired();
            builder.Property(s => s.Title).IsRequired();
        }
    }
}