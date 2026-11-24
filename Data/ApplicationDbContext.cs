//Fajar Raja Nico N
//2481023
//FrameWork.Net
//TI

using Microsoft.EntityFrameworkCore;
using StudentinformationSystem.Models;

namespace StudentinformationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students => Set<Student>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity.HasIndex(s => s.NIM).IsUnique();
                entity.Property(s => s.NIM).HasMaxLength(20).IsRequired();
                entity.Property(s => s.Name).HasMaxLength(120).IsRequired();
                entity.Property(s => s.Major).HasMaxLength(100).IsRequired();
            });
        }
    }
}