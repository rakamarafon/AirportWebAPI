using System.Collections.Generic;
using System.Linq;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class DepartureRepository : IRepository<DepartureModel>
    {
        private List<DepartureModel> list;

        public DepartureRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            list = new List<DepartureModel>
            {
                new DepartureModel {Id = 1, FlightNumber = "DP0001", DepartureDate = "13.07.2018", Crew = 1, Aircraft = 1},
                new DepartureModel {Id = 2, FlightNumber = "KV0001", DepartureDate = "14.07.2018", Crew = 2, Aircraft = 3},
                new DepartureModel {Id = 3, FlightNumber = "LV0001", DepartureDate = "15.07.2018", Crew = 1, Aircraft = 1}
            };
        }

        public DepartureModel AddEntry(DepartureModel entity)
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

        public IEnumerable<DepartureModel> GetAll()
        {
            return list;
        }

        public DepartureModel GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public DepartureModel RemoveEntity(int id)
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

        public DepartureModel UpdateEntity(DepartureModel entity)
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
