using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace ComicsTests
{
    public sealed class TestHelper
    {
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            return config;
        }
        public static TDbContext CreateDbContext<TDbContext>() where TDbContext : DbContext
        {
            var connectionString = InitConfiguration().GetConnectionString("PostgreDbConnection");
            var optionsBuilder = new DbContextOptionsBuilder<TDbContext>();
            var context = Activator.CreateInstance(typeof(TDbContext), optionsBuilder.Options) as TDbContext;
            context.Database.SetCommandTimeout(TimeSpan.FromMinutes(1));
            return context;
        }
    }
}
