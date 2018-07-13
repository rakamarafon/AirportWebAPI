using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Employee : BaseObject
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string BirthDate { get; set; }
    }
}
