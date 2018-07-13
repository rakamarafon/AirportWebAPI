using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.BusinessLayer.Services;
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

            services.AddSingleton<BaseRepository<PilotModel>, PilotRepository>();
            services.AddScoped<IService<Pilot>, PilotService>();

            services.AddSingleton<BaseRepository<StewardessesModel>, StewardessesRepository>();
            services.AddScoped<IService<Stewardesses>, StewardessesService>();

            services.AddSingleton<BaseRepository<CrewModel>, CrewRepository>();
            services.AddScoped<IService<Crew>, CrewService>();

            services.AddSingleton<BaseRepository<AirTypeModel>, AirTypeRepository>();
            services.AddScoped<IService<AirType>, AirTypeService>();

            services.AddSingleton<BaseRepository<AircraftModel>, AircraftRepository>();
            services.AddScoped<IService<Aircraft>, AircraftService>();

            services.AddSingleton<BaseRepository<TicketModel>, TicketRepository>();
            services.AddScoped<IService<Ticket>, TicketService>();

            services.AddSingleton<BaseRepository<FlightModel>, FlightRepository>();
            services.AddScoped<IService<Flight>, FlightService>();

            services.AddSingleton<BaseRepository<DepartureModel>, DepartureRepository>();
            services.AddScoped<IService<Departure>, DepartureService>();

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

                cfg.CreateMap<CrewModel, Crew>();
                cfg.CreateMap<Crew, CrewModel>();

                cfg.CreateMap<AirTypeModel, AirType>();
                cfg.CreateMap<AirType, AirTypeModel>();

                cfg.CreateMap<AircraftModel, Aircraft>();
                cfg.CreateMap<Aircraft, AircraftModel>();

                cfg.CreateMap<TicketModel, Ticket>();
                cfg.CreateMap<Ticket, TicketModel>();

                cfg.CreateMap<FlightModel, Flight>();
                cfg.CreateMap<Flight, FlightModel>();

                cfg.CreateMap<DepartureModel, Departure>();
                cfg.CreateMap<Departure, DepartureModel>();
            });

            return config;
        }
    }
}
