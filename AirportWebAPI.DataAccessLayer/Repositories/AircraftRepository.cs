using System.Collections.Generic;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class AircraftRepository : BaseRepository<AircraftModel>
    {
        public AircraftRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<AircraftModel>
            {
                new AircraftModel { Id = 1, Name = "Razor", AirType = 1, ReleaseDate = "17.02.2016", LifeTime = "123121241241"},
                new AircraftModel { Id = 2, Name = "Pigeon", AirType = 2, ReleaseDate = "10.1.2010", LifeTime = "3465345345345"}
            };
        }      
    }
}
