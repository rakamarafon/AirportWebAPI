using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.BusinessLayer.Services;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AirportWebAPI.DataAccessLayer.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AirportWebAPI
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

            var mapper = MapperConfiguration().CreateMapper();

            services.AddSingleton<IRepository<PilotModel>, PilotRepository>();
            services.AddScoped<IService<Pilot>, PilotService>();

            services.AddSingleton<IRepository<StewardessesModel>, StewardessesRepository>();
            services.AddScoped<IService<Stewardesses>, StewardessesService>();

            services.AddSingleton<IRepository<CrewModel>, CrewRepository>();
            services.AddScoped<IService<Crew>, CrewService>();

            services.AddScoped(_ => mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PilotModel, Pilot>();
                cfg.CreateMap<Pilot, PilotModel>();
                cfg.CreateMap<StewardessesModel, Stewardesses>();
                cfg.CreateMap<Stewardesses, StewardessesModel>();
            });

            return config;
        }
    }
}
