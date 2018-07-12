using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Aircraft : BaseObject
    {
        private string _name;
        private int _airType;
        private string _releaseDate;
        private string _lifeTime;

        public string Name
        {
            get { return _name; }
            set { if (value != null) _name = value; }
        }

        public int AirType
        {
            get { return _airType; }
            set { if (value > 0) _airType = value; }
        }

        public string ReleaseDate
        {
            get { return _releaseDate; }
            set { if (value != null) _releaseDate = value; }
        }

        public string LifeTime
        {
            get { return _lifeTime; }
            set { if (value != null) _lifeTime = value; }
        }
    }
}
