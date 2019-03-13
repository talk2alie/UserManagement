using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.ServiceBus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Data;
using UserManagement.Models;

namespace UserManagement
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<FitnessDbContext>(optionsBuilder =>
            {
                const string name = "FitnessDB";
                var connectionString = Configuration.GetConnectionString(name);
                optionsBuilder.UseSqlServer(connectionString);
            });

            services.AddTransient<ITopicClient>(ServiceProvider =>
            {
                var serviceBus = new ServiceBus();
                Configuration.Bind("ServiceBus", serviceBus);
                return new TopicClient(serviceBus.ConnectionString, serviceBus.TopicName);
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
