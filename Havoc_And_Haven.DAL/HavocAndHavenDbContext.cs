using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.DAL
{
    public class HavocAndHavenDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
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
            modelBuilder.Entity<Users>().HasKey(u => u.UserId);
            modelBuilder.Entity<Headquarters>().HasKey(h => h.HeadquartersId);
            modelBuilder.Entity<Lair>().HasKey(l => l.LairId);
            modelBuilder.Entity<Location>().HasKey(c => c.LocationId);
            modelBuilder.Entity<CrisisEvent>().HasKey(e => e.CrisisId);
            modelBuilder.Entity<Battle>().HasKey(b => b.BattleId);

                // CrisisEvent relationships
            modelBuilder.Entity<CrisisEvent>()
                .HasOne(ce => ce.Location)
                .WithMany(l => l.CrisisEvents)
                .HasForeignKey(ce => ce.LocationId);

            modelBuilder.Entity<CrisisEvent>()
                .HasMany(ce => ce.Heroes)
                .WithMany() // Assuming Users (Heroes) have a collection of CrisisEvents
                .UsingEntity<Dictionary<string, object>>(
                    "CrisisEventHeroes", // This will be the name of the join table
                    j => j.HasOne<Users>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<CrisisEvent>().WithMany().HasForeignKey("CrisisEventId")
                );

            // Villains many-to-many relationship
            modelBuilder.Entity<CrisisEvent>()
                .HasMany(ce => ce.Villains)
                .WithMany() // Assuming Users (Villains) have a collection of CrisisEvents
                .UsingEntity<Dictionary<string, object>>(
                    "CrisisEventVillains", // This will be the name of the join table
                    j => j.HasOne<Users>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<CrisisEvent>().WithMany().HasForeignKey("CrisisEventId")
                );

            // Battle relationships
            modelBuilder.Entity<Battle>()
                .HasOne(b => b.CrisisEvent)
                .WithMany()
                .HasForeignKey(b => b.CrisisId);

            // User relationships
            modelBuilder.Entity<Users>()
                .HasOne(u => u.Headquarters)
                .WithMany(h => h.Heroes)
                .HasForeignKey(u => u.HeadquartersId);
            modelBuilder.Entity<Users>()
                .HasOne(u => u.Lair)
                .WithMany()
                .HasForeignKey(u => u.LairId);

            // Location relationships
            modelBuilder.Entity<Location>()
                .HasMany(l => l.CrisisEvents)
                .WithOne(ce => ce.Location)
                .HasForeignKey(ce => ce.LocationId);

            // Headquarters relationships
            modelBuilder.Entity<Headquarters>()
                .HasOne(h => h.Location)
                .WithMany()
                .HasForeignKey(h => h.LocationId);
            // Lair relationships
            modelBuilder.Entity<Lair>()
                .HasOne(h => h.Location)
                .WithMany()
                .HasForeignKey(h => h.LocationId);

            // Property Configurations
            modelBuilder.Entity<Users>().Property(u => u.FirstName)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Users>().Property(u => u.LastName)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Users>().Property(u => u.Email)
                .IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Users>().Property(u => u.Alias)
                .IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Users>().Property(u => u.Role)
                .IsRequired();
            modelBuilder.Entity<Users>().Property(u => u.OriginStory)
            .HasMaxLength(1000);
            modelBuilder.Entity<Users>().Property(u => u.BattleId);
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
            //modelBuilder.Entity<CrisisEvent>().Property(ce => ce.ResultingBattle);
            modelBuilder.Entity<Battle>().Property(b => b.IncidentBegan);
            modelBuilder.Entity<Battle>().Property(b => b.Winner)
                .HasMaxLength(100);
        }
    }
}


