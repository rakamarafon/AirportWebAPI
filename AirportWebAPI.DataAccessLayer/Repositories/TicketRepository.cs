using AirportWebAPI.DataAccessLayer.Interfaces;
using AirportWebAPI.DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class TicketRepository : IRepository<TicketModel>
    {
        private List<TicketModel> list;

        public TicketRepository()
        {
            CreateSeeds();
        }

        private void CreateSeeds()
        {
            list = new List<TicketModel>
            {
                new TicketModel {Id = 1, Price = 2300, FlightNumber = "DP0001"},
                new TicketModel {Id = 2, Price = 1500, FlightNumber = "KV0001"},
                new TicketModel {Id = 3, Price = 2500, FlightNumber = "LV0001"}
            };
        }

        public TicketModel AddEntry(TicketModel entity)
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

        public IEnumerable<TicketModel> GetAll()
        {
            return list;
        }

        public TicketModel GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public TicketModel RemoveEntity(int id)
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

        public TicketModel UpdateEntity(TicketModel entity)
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
