using G_NET68_EF_Assignment_2.Configs;
using G_NET68_EF_Assignment_2.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.context
{
    internal class EventDBcontext:DbContext
    {


        public DbSet<organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<AttendeeBadge> AttendeeBadges { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CC62RI3\\SQLEXPRESS;Database=EventHub;Trusted_Connection=True;TrustServerCertificate = true");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new Configs.EventConfiguration());
            modelBuilder.ApplyConfiguration(new Configs.OrganizerProfileconfig());
            modelBuilder.ApplyConfiguration(new Badgeconfig());



            modelBuilder.Entity<AttendeeBadge>(entity =>
            {
                
                entity.HasKey(ab => new { ab.AttendeeId, ab.BadgeId });

                
                entity.HasOne(ab => ab.Attendee)
                      .WithMany(a => a.AttendeeBadges)
                      .HasForeignKey(ab => ab.AttendeeId);

                
                entity.HasOne(ab => ab.Badge)
                      .WithMany(b => b.AttendeeBadges)
                      .HasForeignKey(ab => ab.BadgeId);

              
                entity.ToTable("AttendeeBadges");
            });



        }
    }
}
