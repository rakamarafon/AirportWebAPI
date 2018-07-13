using System.Collections.Generic;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class DepartureRepository : BaseRepository<DepartureModel>
    {
        public DepartureRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<DepartureModel>
            {
                new DepartureModel {Id = 1, FlightNumber = "DP0001", DepartureDate = "13.07.2018", Crew = 1, Aircraft = 1},
                new DepartureModel {Id = 2, FlightNumber = "KV0001", DepartureDate = "14.07.2018", Crew = 2, Aircraft = 3},
                new DepartureModel {Id = 3, FlightNumber = "LV0001", DepartureDate = "15.07.2018", Crew = 1, Aircraft = 1}
            };
        }
    }
}
