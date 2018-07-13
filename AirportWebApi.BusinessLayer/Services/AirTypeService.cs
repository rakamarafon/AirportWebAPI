using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using AirportWebAPI.DataAccessLayer.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.BusinessLayer.Services
{
    public class AirTypeService : IService<AirType>
    {
        private readonly BaseRepository<AirTypeModel> repository;
        private readonly IMapper mapper;

        public AirTypeService(BaseRepository<AirTypeModel> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public AirType AddEntry(AirType entity)
        {
            var temp = repository.AddEntry(mapper.Map<AirType, AirTypeModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<AirTypeModel, AirType>(temp);
            }
        }

        public List<AirType> GetAll()
        {
            var temp = repository.GetAll();
            return temp.Select(mapper.Map<AirTypeModel, AirType>).ToList();
        }

        public AirType GetById(int id)
        {
            var temp = repository.GetById(id);
            return mapper.Map<AirTypeModel, AirType>(temp);
        }

        public AirType RemoveEntry(int id)
        {
            return mapper.Map<AirTypeModel, AirType>(repository.RemoveEntity(id));
        }

        public AirType UpdateEntry(AirType entity)
        {
            var temp = repository.UpdateEntity(mapper.Map<AirType, AirTypeModel>(entity));
            if (temp == null)
            {
                return null;
            }
            else
            {
                return mapper.Map<AirTypeModel, AirType>(temp);
            }
        }
    }
}
