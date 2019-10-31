using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Proletarians.Utility;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigurationBuilder configuration = new ConfigurationBuilder();
            configuration.AddJsonFile("appsettings.json");
            var buildConfig = configuration.Build();
            ProjectUtility.Instance.Initialize(buildConfig);
            CreateHostBuilder(args).Build().Run();
           
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
