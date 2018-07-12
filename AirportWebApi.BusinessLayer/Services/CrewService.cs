using System.Collections.Generic;
using System.Linq;
using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class CrewService : IService<Crew>
    {
        private readonly IRepository<CrewModel> repository;
        private readonly IMapper mapper;

        public CrewService(IRepository<CrewModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Crew AddEntry(Crew entity)
        {
            var temp = repository.AddEntry(mapper.Map<Crew, CrewModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<CrewModel, Crew>(temp);
            }
        }

        public List<Crew> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<CrewModel, Crew>).ToList();
        }

        public Crew GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<CrewModel, Crew>(temp);
        }

        public Crew RemoveEntry(int id)
        {
            return mapper.Map<CrewModel, Crew>(repository.RemoveEntity(id));
        }

        public Crew UpdateEntry(Crew entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<Crew, CrewModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<CrewModel, Crew>(temp);
            }
        }
    }
}
