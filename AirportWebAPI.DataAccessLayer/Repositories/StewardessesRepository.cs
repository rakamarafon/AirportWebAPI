using System.Collections.Generic;
using System.Linq;
using AirportWebAPI.DataAccessLayer.Model;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public class StewardessesRepository : BaseRepository<StewardessesModel>
    {
        public StewardessesRepository()
        {
            CreateSeeds();
        }

        public override void CreateSeeds()
        {
            list = new List<StewardessesModel>
            {
                new StewardessesModel { Id = 1, FirstName = "Sara", SecondName = "Parker", BirthDate = "23.04.1995" },
                new StewardessesModel { Id = 2, FirstName = "Djesika", SecondName = "Flight",  BirthDate = "19.12.1990" },
                new StewardessesModel { Id = 3, FirstName = "Barbra", SecondName = "Streisand", BirthDate = "10.05.1960" },
                new StewardessesModel { Id = 4, FirstName = "Merilin", SecondName = "Monro", BirthDate = "10.10.1970"}
            };
        }
    }
}
