using Acm.BusinessLogic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using System;
using TaskTime.BusinessLogic;
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
                           .AddJsonFile("AppSettings.json", optional: false, reloadOnChange: true);

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

            services.AddSingleton(Configuration.GetSection("Acm").Get<AcmConfiguration>());
            services.AddSingleton(Configuration.GetSection("WiiUSmash4").Get<WiiUSmash4Configuration>());
            services.AddSingleton(Configuration.GetSection("TaskTime").Get<TaskTimeConfiguration>());

            services.AddDbContext<AcmContext>(o => o.UseSqlServer(Configuration["Acm:AcmDbConnectionString"]));
            services.AddDbContext<AcmContext>(o => o.UseSqlServer(Configuration["TaskTime:TaskTimeDbConnectionString"]));

            bool mockData = Convert.ToBoolean(Configuration["Global:Mock"]);

            if (mockData)
            {
                services.AddScoped<IFighterRepository, MockFighterRepository>();
                services.AddScoped<IMemberRepository, MockMemberRepository>();
            }
            else
            {
                services.AddScoped<IFighterRepository, FighterRepository>();
                services.AddScoped<IMemberRepository, MemberRepository>();
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
