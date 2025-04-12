using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.DAL
{
    public class HavocAndHavenDbContext : IdentityDbContext
    {
        public DbSet<Headquarters> Headquarters { get; set; }
        public DbSet<Lair> Lairs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<CrisisEvent> CrisisEvents { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public HavocAndHavenDbContext(DbContextOptions<HavocAndHavenDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Primary Keys
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
            modelBuilder.Entity<Headquarters>().HasKey(h => h.HeadquartersId);
            modelBuilder.Entity<Lair>().HasKey(l => l.LairId);
            modelBuilder.Entity<Location>().HasKey(c => c.LocationId);
            modelBuilder.Entity<CrisisEvent>().HasKey(e => e.CrisisId);
            modelBuilder.Entity<Battle>().HasKey(b => b.BattleId);

            // Relationships
            modelBuilder.Entity<User>()
                .HasOne(u => u.Headquarters)
                .WithMany(h => h.Heroes)
                .HasForeignKey(u => u.HeadquartersId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Lair)
                .WithMany(l => l.Villains)
                .HasForeignKey(u => u.LairId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CrisisEvent>()
                .HasOne(e => e.Location)
                .WithMany(c => c.CrisisEvents)
                .HasForeignKey(e => e.LocationId);
            modelBuilder.Entity<CrisisEvent>()
                .HasMany(e => e.Heroes)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CrisisEvent>()
                .HasMany(e => e.Villains)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Battle>()
                .HasOne(b => b.CrisisEvent)
                .WithMany()
                .HasForeignKey(b => b.CrisisId);

            // Property Configurations
            modelBuilder.Entity<User>().Property(u => u.FirstName)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.LastName)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Email)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Alias)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Role)
                .IsRequired();
            modelBuilder.Entity<User>().Property(u => u.OriginStory)
            .HasMaxLength(1000);
            modelBuilder.Entity<Headquarters>().Property(h => h.BaseTitle)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Headquarters>().Property(h => h.Capacity)
            .IsRequired();
            modelBuilder.Entity<Headquarters>().Property(h => h.Description)
                .HasMaxLength(500);
            modelBuilder.Entity<Lair>().Property(l => l.BaseTitle)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Lair>().Property(l => l.Capacity)
                .IsRequired();
            modelBuilder.Entity<Lair>().Property(l => l.Description)
                .IsRequired();
            modelBuilder.Entity<Location>().Property(c => c.Neighborhood)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Location>().Property(c => c.Address)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Location>().Property(c => c.Description)
                .HasMaxLength(500);
            modelBuilder.Entity<Location>().Property(c => c.Type)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<CrisisEvent>().Property(ce => ce.Title)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<CrisisEvent>().Property(ce => ce.CreatedAt);
            modelBuilder.Entity<CrisisEvent>().Property(ce => ce.IsResolved);
            modelBuilder.Entity<CrisisEvent>().Property(ce => ce.ResultingBattle);
            modelBuilder.Entity<Battle>().Property(b => b.IncidentBegan);
            modelBuilder.Entity<Battle>().Property(b => b.Winner)
                .HasMaxLength(100);
        }
    }
}


