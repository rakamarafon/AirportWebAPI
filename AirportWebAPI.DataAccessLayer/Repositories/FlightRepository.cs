using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class FlightRepository : IRepository<FlightModel>
    {
        private List<FlightModel> list;

        public FlightRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            list = new List<FlightModel>
            {
                new FlightModel {Id = 1, Number = "DP0001", DeparturePoint = 1, DepartureTime = "13.07.2018 20:00", DestinationPoint = 2, DestinationTime = "13.07.2018 20:00", Tickets = new List<int> { 1} },
                new FlightModel {Id = 2, Number = "KV0001", DeparturePoint = 1, DepartureTime = "13.07.2018 20:00", DestinationPoint = 3, DestinationTime = "13.07.2018 20:00", Tickets = new List<int> { 1} }
            };
        }

        public FlightModel AddEntry(FlightModel entity)
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

        public IEnumerable<FlightModel> GetAll()
        {
            return list;
        }

        public FlightModel GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public FlightModel RemoveEntity(int id)
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

        public FlightModel UpdateEntity(FlightModel entity)
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
