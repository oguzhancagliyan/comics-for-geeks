using System;
using System.Collections.Generic;
using Cellula.Dtos.HeroesDtos.Marvel;
using Cellula.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proletarians.Interfaces;
using Proletarians.Services;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpClient("marvelBase", c =>
             {
                 c.BaseAddress = new Uri("https://gateway.marvel.com/");
                 c.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
             });
            services.AddEntityFrameworkNpgsql().AddDbContext<ComicsForGeeksContext>(optionsAction: opt => opt.UseNpgsql(Configuration.GetConnectionString("PostgreDbConnection")));
            services.AddScoped<ComicsForGeeksContext>();
            services.AddScoped<IHeroRequestBase<MarvelHeroRequestDto, List<MarvelHeroResponseDto>>, MarvelHeroService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
