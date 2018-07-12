using System.Collections.Generic;
using System.Linq;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class AirTypeRepository : IRepository<AirTypeModel>
    {
        private List<AirTypeModel> list;

        public AirTypeRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            list = new List<AirTypeModel>
            {
                new AirTypeModel { Id = 1, Model = "boeing 737", FlightData = new FlightDataModel { Id = 1, CruisingSpeed = 700, MaxAltitude = 10000, FlightRange = 2000, Carrying = 1300}, SeatsNumber = 120 },
                new AirTypeModel { Id = 2, Model = "boeing 777", FlightData = new FlightDataModel { Id = 2, CruisingSpeed = 750, MaxAltitude = 10000, FlightRange = 2500, Carrying = 1500}, SeatsNumber = 95 },
                new AirTypeModel { Id = 3, Model = "Mariya", FlightData = new FlightDataModel { Id = 3, CruisingSpeed = 600, MaxAltitude = 10000, FlightRange = 3000, Carrying = 1800}, SeatsNumber = 130 }
            };
        }
        public AirTypeModel AddEntry(AirTypeModel entity)
        {
            if (entity != null)
            {
                var maxId = list.Max(x => x.Id);
                entity.Id = (maxId + 1);
                list.Add(entity);
                return entity;
            }
            else return null;
        }

        public IEnumerable<AirTypeModel> GetAll()
        {
            return list;
        }

        public AirTypeModel GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public AirTypeModel RemoveEntity(int id)
        {
            var temp = list.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
            {
                list.Remove(temp);
                return temp;
            }
            else
            {
                return null;
            }
        }

        public AirTypeModel UpdateEntity(AirTypeModel entity)
        {
            var temp = list.Where(x => x.Id == entity.Id).FirstOrDefault();
            if (temp != null)
            {
                list.Remove(temp);
                list.Add(entity);
                return entity;
            }
            else
            {
                return null;
            }
        }
    }
}
