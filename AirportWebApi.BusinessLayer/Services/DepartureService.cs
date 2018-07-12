using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class DepartureService : IService<Departure>
    {
        private readonly IRepository<DepartureModel> repository;
        private readonly IMapper mapper;

        public DepartureService(IRepository<DepartureModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Departure AddEntry(Departure entity)
        {
            var temp = repository.AddEntry(mapper.Map<Departure, DepartureModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<DepartureModel, Departure>(temp);
            }
        }

        public List<Departure> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<DepartureModel, Departure>).ToList();
        }

        public Departure GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<DepartureModel, Departure>(temp);
        }

        public Departure RemoveEntry(int id)
        {
            return mapper.Map<DepartureModel, Departure>(repository.RemoveEntity(id));
        }

        public Departure UpdateEntry(Departure entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<Departure, DepartureModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<DepartureModel, Departure>(temp);
            }
        }
    }
}
