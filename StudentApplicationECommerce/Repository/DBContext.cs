using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using StudentWebApp.Models;
namespace StudentWebApp.Repository
{
    public class DBContext: DbContext
    {
       public  DbSet<Students> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string concat = @"server=localhost;port=3306;database=msnet;user=root;password=Rushi9499;";
          
            optionsBuilder.UseMySQL(concat);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.studId);
                entity.Property(e=>e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e=>e.email).IsRequired().HasMaxLength(100);
                entity.Property(e=>e.MobNo).IsRequired().HasMaxLength(60);
                entity.Property(e=>e.address).IsRequired().HasMaxLength(200);
                entity.Property(e=>e.AdmissionDate).HasColumnType("TIMESTAMP").HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e=>e.fees).IsRequired();
                entity.Property(e => e.status).IsRequired().HasColumnType("Enum").HasDefaultValue("Active");


            });
            modelBuilder.Entity<Students>().ToTable("student");
        }

    }
}
