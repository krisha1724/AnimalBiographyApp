using Microsoft.EntityFrameworkCore;
using AnimalBiographyApp.Models;

namespace AnimalBiographyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure MySQL-specific settings if needed
            modelBuilder.Entity<Animal>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Animal>()
                .Property(a => a.Species)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Animal>()
                .Property(a => a.Habitat)
                .HasMaxLength(200);

            modelBuilder.Entity<Animal>()
                .Property(a => a.Description)
                .HasMaxLength(2000);

            modelBuilder.Entity<Animal>()
                .Property(a => a.ImageUrl)
                .HasMaxLength(500);

            modelBuilder.Entity<Animal>()
                .Property(a => a.Diet)
                .HasMaxLength(200);

            modelBuilder.Entity<Animal>()
                .Property(a => a.ConservationStatus)
                .HasMaxLength(100);
        }
    }
}
