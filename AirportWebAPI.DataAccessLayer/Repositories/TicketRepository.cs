using AirportWebAPI.DataAccessLayer.Model;
using System.Collections.Generic;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class TicketRepository : BaseRepository<TicketModel>
    {
        public TicketRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<TicketModel>
            {
                new TicketModel {Id = 1, Price = 2300, FlightNumber = "DP0001"},
                new TicketModel {Id = 2, Price = 1500, FlightNumber = "KV0001"},
                new TicketModel {Id = 3, Price = 2500, FlightNumber = "LV0001"}
            };
        }
    }
}
