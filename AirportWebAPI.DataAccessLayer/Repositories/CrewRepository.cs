using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class CrewRepository : IRepository<CrewModel>
    {
        private List<CrewModel> list;

        public CrewRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            list = new List<CrewModel>
            {
                new CrewModel { Id = 1, Pilot = 1, Stewardesses = new List<int> { 1, 2} },
                new CrewModel { Id = 2, Pilot = 2, Stewardesses = new List<int> {3} }
            };
        }
        public CrewModel AddEntry(CrewModel entity)
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

        public IEnumerable<CrewModel> GetAll()
        {
            return list;
        }

        public CrewModel GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public CrewModel RemoveEntity(int id)
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

        public CrewModel UpdateEntity(CrewModel entity)
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
