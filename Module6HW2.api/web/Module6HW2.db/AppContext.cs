using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Module6HW2.db.Model;
namespace Module6HW2.db
{
    public class AppContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EP3R97J;Initial Catalog=ProductAPI;Integrated Security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Product Entity

            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Product>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.PhotoURL)
                .IsRequired();
        }

    }
}
