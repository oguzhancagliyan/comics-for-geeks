using Microsoft.Extensions.Configuration;
using System;

namespace Proletarians.Utility
{
    public class ProjectUtility
    {
        IConfiguration Configuration;
        public IConfiguration GetConfiguration() => Configuration;
        public static ProjectUtility Instance { get; } = new ProjectUtility();

        private static readonly Lazy<ProjectUtility> lazy = new Lazy<ProjectUtility>();
        public string GetDatabaseConnection() => Configuration.GetConnectionString("DefaultConnection");
        public string GetRedisConnection() => Configuration.GetConnectionString("RedisConnectionString");
        public string GetMongoConnection() => Configuration.GetConnectionString("MongoProductDb");

        static ProjectUtility()
        {

        }
        ProjectUtility()
        {

        }
        public void Initialize(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
