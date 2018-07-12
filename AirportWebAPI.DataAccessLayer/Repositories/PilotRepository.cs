using System;
using System.Linq;
using System.Collections.Generic;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class PilotRepository : IRepository<PilotModel>
    {
        private List<PilotModel> pilots;
        public PilotRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            pilots = new List<PilotModel>
            {
                new PilotModel { Id = 1, FirstName = "Donald", SecondName = "Trump", BirthDate = "11.01.1960", Experience = 10},
                new PilotModel { Id = 2, FirstName = "George", SecondName = "Bush" , BirthDate = "29.06.1975", Experience = 5}
            };
        }

        public PilotModel AddEntry(PilotModel entity)
        {
            if (entity != null)
            {
                var maxId = pilots.Max(x => x.Id);
                entity.Id = (maxId + 1);
                pilots.Add(entity);
                return entity;
            }
            else return null;
        }

        public IEnumerable<PilotModel> GetAll()
        {
            return pilots;
        }

        public PilotModel GetById(int id)
        {
            return pilots.Where(x => x.Id == id).FirstOrDefault();
        }

        public PilotModel RemoveEntity(int id)
        {
            var temp = pilots.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
            {
                pilots.Remove(temp);
                return temp;
            }
            else
            {
                return null;
            }
        }

        public PilotModel UpdateEntity(PilotModel entity)
        {
            var temp = pilots.Where(x => x.Id == entity.Id).FirstOrDefault();
            if(temp != null)
            {
              pilots.Remove(temp);
              pilots.Add(entity);
              return entity;
            }
            else
            {
                return null;
            }
        }      
    }
}
