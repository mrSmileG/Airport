using System;
using BL.Services;
using DAL;
using DAL.EF;
using DTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models;
using AutoMapper;
using BL;

namespace WebApi
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
            services.AddScoped<AutoMapperService>();
            services.AddSingleton<IRepositoryUnit, RepositoryUnit>();
            services.AddScoped<IService<StewardDto>, StewardService>();
            services.AddScoped<IService<PlaneTypeDto>, PlaneTypeService>();
            services.AddScoped<IService<AircrewDto>, AircrewService>();
            services.AddScoped<IService<PilotDto>, PilotService>();
            services.AddScoped<IService<PlaneDto>, PlaneService>();
            services.AddScoped<IService<FlightDto>, FlightService>();
            services.AddScoped<IService<DepartureDto>, DepartureService>();
            services.AddScoped<IService<TicketDto>, TicketService>();

            services.AddScoped<IRepositoryUnit, RepositoryUnit>();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AirportDb")));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMiddleware<ErrorHandler>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (!serviceScope.ServiceProvider.GetService<AppDbContext>().AllMigrationsApplied())
                {
                    serviceScope.ServiceProvider.GetService<AppDbContext>().Database.Migrate();
                    serviceScope.ServiceProvider.GetService<AppDbContext>().EnsureSeeded();
                }

            }

            app.UseMvc();
        }
    }
}
