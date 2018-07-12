using System.Collections.Generic;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class PilotRepository : BaseRepository<PilotModel>
    {
        public PilotRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<PilotModel>
            {
                new PilotModel { Id = 1, FirstName = "Donald", SecondName = "Trump", BirthDate = "11.01.1960", Experience = 10},
                new PilotModel { Id = 2, FirstName = "George", SecondName = "Bush" , BirthDate = "29.06.1975", Experience = 5}
            };
        }
    }
}
