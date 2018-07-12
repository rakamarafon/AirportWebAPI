using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class AircraftService : IService<Aircraft>
    {
        private readonly IRepository<AircraftModel> repository;
        private readonly IMapper mapper;

        public AircraftService(IRepository<AircraftModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Aircraft AddEntry(Aircraft entity)
        {
            var temp = repository.AddEntry(mapper.Map<Aircraft, AircraftModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<AircraftModel, Aircraft>(temp);
            }
        }

        public List<Aircraft> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<AircraftModel, Aircraft>).ToList();
        }

        public Aircraft GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<AircraftModel, Aircraft>(temp);
        }

        public Aircraft RemoveEntry(int id)
        {
            return mapper.Map<AircraftModel, Aircraft>(repository.RemoveEntity(id));
        }

        public Aircraft UpdateEntry(Aircraft entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<Aircraft, AircraftModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<AircraftModel, Aircraft>(temp);
            }
        }
    }
}
