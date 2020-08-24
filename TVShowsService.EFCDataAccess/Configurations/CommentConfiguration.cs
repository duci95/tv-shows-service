using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TVShowsService.Domain;

namespace TVShowsService.EFCDataAccess.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.CommentText).IsRequired();
            builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(c => c.IsDeleted).HasDefaultValue(false);           
        }
    }
}