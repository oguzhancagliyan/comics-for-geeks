using Microsoft.EntityFrameworkCore;

namespace Cellula.Entity
{
    public class ComicsForGeeksContext : DbContext
    {
        public ComicsForGeeksContext(DbContextOptions<ComicsForGeeksContext> options) : base(options)
        {

        }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CategoriesEntity> Categories { get; set; }
        
    }
}
