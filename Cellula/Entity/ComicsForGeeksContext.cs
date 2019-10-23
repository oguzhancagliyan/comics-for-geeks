using Microsoft.EntityFrameworkCore;

namespace Cellula.Entity
{
    public class ComicsForGeeksContext : DbContext
    {
        public ComicsForGeeksContext(DbContextOptions<ComicsForGeeksContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID =postgres;Password=003003;Server=localhost;Port=5432;Database=testDb;Integrated Security=true;Pooling=true;");
        }       
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CategoriesEntity> Categories { get; set; }
        public DbSet<GenderEntity> Genders { get; set; }
        public DbSet<UserCategoryEntity> UserCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCategoryEntity>().HasKey(bc => new { bc.CategoryId, bc.UserId });
            modelBuilder.Entity<UserCategoryEntity>()
            .HasOne(bc => bc.User)
            .WithMany(b => b.UserCategories)
            .HasForeignKey(bc => bc.UserId);

            modelBuilder.Entity<UserCategoryEntity>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.UserCategories)
                .HasForeignKey(bc => bc.CategoryId);

        }
    }
}
