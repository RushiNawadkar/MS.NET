using Microsoft.EntityFrameworkCore;
using OnlineStudentPortal.Entity;
namespace OnlineStudentPortal.Repository
{
    public class StoreContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Concat = @"server=localhost;port=3306;database=msnet;user=root;password=Rushi9499;";
            optionsBuilder.UseMySQL(Concat);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            { 
                entity.HasKey(e=>e.studId);
                entity.Property(e=>e.Name).IsRequired();
               // entity.Property(e=>e.AdmissionDate).IsRequired().HasColumnType("TIMESTAMP").HasDefaultValue("CURRENT_TIMESTAMP");
                //entity.Property(e => e.status).HasColumnType("ENUM").HasDefaultValue("Active");
            });
            modelBuilder.Entity<Student>().ToTable("Student");

        }
    }
}

