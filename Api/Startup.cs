using GlobalTools.BusinessLogic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Pongo.BusinessLogic;
using System;
using WiiUSmash4.BusinessLogic;

namespace MatthewGollaher
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                           .SetBasePath(env.ContentRootPath)
                           .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true)
                           .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.AddOptions();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
            });

            services.AddSingleton(Configuration.GetSection("GlobalTools").Get<GlobalToolsConfiguration>());
            services.AddSingleton(Configuration.GetSection("WiiUSmash4").Get<WiiUSmash4Configuration>());
            services.AddSingleton(Configuration.GetSection("Pongo").Get<PongoConfiguration>());

            services.AddDbContext<PongoContext>(o => o.UseSqlServer(Configuration["Pongo:PongoDbConnectionString"]));


            bool mockData = Convert.ToBoolean(Configuration["Global:Mock"]);

            if (mockData)
            {
                services.AddScoped<IFighterRepository, MockFighterRepository>();
            }
            else
            {
                services.AddScoped<IFighterRepository, FighterRepository>();
                services.AddScoped<IUserRepository, UserRepository>();
                services.AddScoped<ITableRepository, TableRepository>();
            }
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseCors("AllowAllHeaders");
            app.UseStatusCodePages();
            app.UseMvc();
        }
    }
}
