﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TVShowsService.Domain;

namespace TVShowsService.EFCDataAccess.Configurations
{
    public class PictureConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.Property(p => p.PicturePath).IsRequired();
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
        }
    }
}
