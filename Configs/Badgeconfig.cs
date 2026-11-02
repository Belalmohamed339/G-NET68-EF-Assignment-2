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
    internal class Badgeconfig : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges");

            builder.HasKey(b => b.BadgeId);

            builder.Property(b => b.BadgeNumber)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.HasIndex(b => b.BadgeNumber)
                  .IsUnique();

            builder.Property(b => b.IssueDate)
                  .IsRequired();


            builder.Property(b => b.Tier)
                  .HasConversion<string>()
                  .HasMaxLength(20)
                  .IsRequired();

            
        }
        
    }
}
