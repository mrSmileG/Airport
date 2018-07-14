using BL.Services;
using DAL;
using DAL.InMemory;
using DTOs;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddMvc();

            services.AddSingleton<IRepositoryUnit, RepositoryUnit>();
            services.AddScoped<IService<StewardDto>, StewardService>();
            services.AddScoped<IService<PlaneTypeDto>, PlaneTypeService>();
            services.AddScoped<IService<AircrewDto>, AircrewService>();
            services.AddScoped<IService<PilotDto>, PilotService>();
            services.AddScoped<IService<PlaneDto>, PlaneService>();
            services.AddScoped<IService<FlightDto>, FlightService>();
            services.AddScoped<IService<DepartureDto>, DepartureService>();
            services.AddScoped<IService<TicketDto>, TicketService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMiddleware<ErrorHandler>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
