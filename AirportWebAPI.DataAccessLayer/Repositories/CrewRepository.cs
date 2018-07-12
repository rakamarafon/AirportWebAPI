using AirportWebAPI.DataAccessLayer.Model;
using System.Collections.Generic;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class CrewRepository : BaseRepository<CrewModel>
    {
        public CrewRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<CrewModel>
            {
                new CrewModel { Id = 1, Pilot = 1, Stewardesses = new List<int> { 1, 2} },
                new CrewModel { Id = 2, Pilot = 2, Stewardesses = new List<int> {3} }
            };
        }      
    }
}
