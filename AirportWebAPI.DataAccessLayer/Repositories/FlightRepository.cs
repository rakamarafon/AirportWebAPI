using AirportWebAPI.DataAccessLayer.Model;
using System.Collections.Generic;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class FlightRepository : BaseRepository<FlightModel>
    {
        public FlightRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<FlightModel>
            {
                new FlightModel {Id = 1, Number = "DP0001", DeparturePoint = 1, DepartureTime = "20:00", DestinationPoint = 2, DestinationTime = "20:00", Tickets = new List<int> { 1} },
                new FlightModel {Id = 2, Number = "KV0001", DeparturePoint = 1, DepartureTime = "20:00", DestinationPoint = 3, DestinationTime = "20:00", Tickets = new List<int> { 1} }
            };
        }
    }
}
