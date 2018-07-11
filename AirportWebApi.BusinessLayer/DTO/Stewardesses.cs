using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Stewardesses
    {
        private string _firstName;
        private string _secondName;
        private string _birthDate;

        public string FirstName
        {
            get { return _firstName; }
            set { if (value != null) _firstName = value; }
        }

        public string SecondName
        {
            get { return _secondName; }
            set { if (value != null) _secondName = value; }
        }

        public string BirthDate
        {
            get { return _birthDate; }
            set { if (value != null) _birthDate = value; }
        }
    }
}
