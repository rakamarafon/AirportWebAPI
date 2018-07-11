﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Pilot
    {
        private string _firstName;
        private string _secondName;
        private string _birthDate;
        private int _experience;

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

        public int Experience
        {
            get { return _experience; }
            set { if (value >= 0) _experience = value; }
        }
    }
}