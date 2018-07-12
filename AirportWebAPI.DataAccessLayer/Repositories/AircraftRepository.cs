using System;
using System.Collections.Generic;
using System.Linq;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class AircraftRepository : IRepository<AircraftModel>
    {
        private List<AircraftModel> list;

        public AircraftRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            list = new List<AircraftModel>
            {
                new AircraftModel { Id = 1, Name = "Razor", AirType = 1, ReleaseDate = "17.02.2016", LifeTime = "123121241241"},
                new AircraftModel { Id = 2, Name = "Pigeon", AirType = 2, ReleaseDate = "10.1.2010", LifeTime = "3465345345345"}
            };
        }

        public AircraftModel AddEntry(AircraftModel entity)
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

        public IEnumerable<AircraftModel> GetAll()
        {
            return list;
        }

        public AircraftModel GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public AircraftModel RemoveEntity(int id)
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

        public AircraftModel UpdateEntity(AircraftModel entity)
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
