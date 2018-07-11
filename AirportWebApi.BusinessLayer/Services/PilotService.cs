using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class PilotService : IService<Pilot>
    {
        private readonly IRepository<PilotModel> repository;
        private readonly IMapper mapper;

        public PilotService(IRepository<PilotModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Pilot AddEntry(Pilot pilot)
        {
           var temp = repository.AddEntry(mapper.Map<Pilot, PilotModel>(pilot));
            if(temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<PilotModel, Pilot>(temp);
            }
        }

        public Pilot GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<PilotModel, Pilot>(temp);
        }

        public List<Pilot> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<PilotModel, Pilot>).ToList();
        }

        public Pilot RemoveEntry(int id)
        {
            return mapper.Map<PilotModel, Pilot>(repository.RemoveEntity(id));
        }

        public Pilot UpdateEntry(Pilot pilot)
        {
            var temp = repository.UpdateEntity(mapper.Map<Pilot, PilotModel>(pilot));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<PilotModel, Pilot>(temp);
            }
        }
    }
}
