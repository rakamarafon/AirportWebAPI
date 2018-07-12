using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class StewardessesService : IService<Stewardesses>
    {
        private readonly IRepository<StewardessesModel> repository;
        private readonly IMapper mapper;

        public StewardessesService(IRepository<StewardessesModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Stewardesses AddEntry(Stewardesses entity)
        {
            var temp = repository.AddEntry(mapper.Map<Stewardesses, StewardessesModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<StewardessesModel, Stewardesses>(temp);
            }
        }

        public List<Stewardesses> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<StewardessesModel, Stewardesses>).ToList();
        }

        public Stewardesses GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<StewardessesModel, Stewardesses>(temp);
        }

        public Stewardesses RemoveEntry(int id)
        {
            return mapper.Map<StewardessesModel, Stewardesses>(repository.RemoveEntity(id));
        }

        public Stewardesses UpdateEntry(Stewardesses entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<Stewardesses, StewardessesModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<StewardessesModel, Stewardesses>(temp);
            }
        }
    }
}
