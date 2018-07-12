using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Repositories;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class FlightService : IService<Flight>
    {
        private readonly BaseRepository<FlightModel> repository;
        private readonly IMapper mapper;

        public FlightService(BaseRepository<FlightModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Flight AddEntry(Flight entity)
        {
            var temp = repository.AddEntry(mapper.Map<Flight, FlightModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<FlightModel, Flight>(temp);
            }
        }

        public List<Flight> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<FlightModel, Flight>).ToList();
        }

        public Flight GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<FlightModel, Flight>(temp);
        }

        public Flight RemoveEntry(int id)
        {
            return mapper.Map<FlightModel, Flight>(repository.RemoveEntity(id));
        }

        public Flight UpdateEntry(Flight entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<Flight, FlightModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<FlightModel, Flight>(temp);
            }
        }
    }
}
