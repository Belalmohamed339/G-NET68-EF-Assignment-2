using G_NET68_EF_Assignment_2.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Configs
{
    internal class OrganizerProfileconfig : IEntityTypeConfiguration<models.organizerprofile>
    {
        public void Configure(EntityTypeBuilder<organizerprofile> builder)
        {
            builder.ToTable("OrganizerProfiles");
            builder.HasKey(op => op.OrganizerProfileId);
            builder.Property(op => op.Biography)
               .HasMaxLength(500);

            builder.Property(op => op.WebsiteUrl)
                   .HasMaxLength(250);

            builder.Property(op => op.LogoUrl)
                   .HasMaxLength(250);

            builder.HasOne(op => op.Organizer)
                   .WithOne(o => o.OrganizerProfile)
                   .HasForeignKey<organizerprofile>(op => op.organizerID);
        }
    }
}
