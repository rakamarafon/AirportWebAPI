using System;
using System.Collections.Generic;
using System.Linq;
using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class StewardessesRepository : IRepository<StewardessesModel>
    {
        private List<StewardessesModel> stewardesses;

        public StewardessesRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            stewardesses = new List<StewardessesModel>
            {
                new StewardessesModel { Id = 1, FirstName = "Sara", SecondName = "Parker", BirthDate = "23.04.1995" },
                new StewardessesModel { Id = 2, FirstName = "Djesika", SecondName = "Flight",  BirthDate = "19.12.1990" },
                new StewardessesModel { Id = 3, FirstName = "Barbra", SecondName = "Streisand", BirthDate = "10.05.1960" },
                new StewardessesModel { Id = 4, FirstName = "Merilin", SecondName = "Monro", BirthDate = "10.10.1970"}
            };
        }

        public StewardessesModel AddEntry(StewardessesModel entity)
        {
            if (entity != null)
            {
                var maxId = stewardesses.Max(x => x.Id);
                entity.Id = (maxId + 1);
                stewardesses.Add(entity);
                return entity;
            }
            else return null;
        }

        public IEnumerable<StewardessesModel> GetAll()
        {
            return stewardesses;
        }

        public StewardessesModel GetById(int id)
        {
            return stewardesses.Where(x => x.Id == id).FirstOrDefault();
        }

        public StewardessesModel RemoveEntity(int id)
        {
            var temp = stewardesses.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
            {
                stewardesses.Remove(temp);
                return temp;
            }
            else
            {
                return null;
            }
        }

        public StewardessesModel UpdateEntity(StewardessesModel entity)
        {
            var temp = stewardesses.Where(x => x.Id == entity.Id).FirstOrDefault();
            if (temp != null)
            {
                stewardesses.Remove(temp);
                stewardesses.Add(entity);
                return entity;
            }
            else
            {
                return null;
            }
        }
    }
}
