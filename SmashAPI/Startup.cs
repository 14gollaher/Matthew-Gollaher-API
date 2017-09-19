using Acm.BusinessLogic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
                           .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddMvcOptions(o => o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter()));

            var connectionString = Startup.Configuration["connectionStrings:cityInfoDBConnectionString"];
            services.AddDbContext<AcmContext>(o => o.UseSqlServer(connectionString));

            bool mockData = Convert.ToBoolean(Configuration["configuration:mock"]);

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

            app.UseStatusCodePages();

            app.UseMvc();
        }
    }
}
