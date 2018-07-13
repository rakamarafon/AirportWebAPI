using System.Collections.Generic;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class AirTypeRepository : BaseRepository<AirTypeModel>
    {
        public AirTypeRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<AirTypeModel>
            {
                new AirTypeModel { Id = 1, Model = "boeing 737", FlightData = new FlightDataModel { Id = 1, CruisingSpeed = 700, MaxAltitude = 10000, FlightRange = 2000, Carrying = 1300}, SeatsNumber = 120 },
                new AirTypeModel { Id = 2, Model = "boeing 777", FlightData = new FlightDataModel { Id = 2, CruisingSpeed = 750, MaxAltitude = 10000, FlightRange = 2500, Carrying = 1500}, SeatsNumber = 95 },
                new AirTypeModel { Id = 3, Model = "Mariya", FlightData = new FlightDataModel { Id = 3, CruisingSpeed = 600, MaxAltitude = 10000, FlightRange = 3000, Carrying = 1800}, SeatsNumber = 130 }
            };
        }      
    }
}
