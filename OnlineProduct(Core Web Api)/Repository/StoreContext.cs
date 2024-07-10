using Microsoft.EntityFrameworkCore;
using ProductWebApplication.Entity;
namespace ProductWebApplication.Repository
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> products {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string concat = @"server=localhost;port=3306;database=msnet;user=root;password=Rushi9499;";
            optionsBuilder.UseMySQL(concat);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.pid);
                entity.Property(e => e.pname);

            });

            modelBuilder.Entity<Product>().ToTable("product");
        }
    }
}
