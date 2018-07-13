using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Flight : BaseObject
    {
        private string _number;             
        private int _departurePoint;
        private string _departureTime;
        private int _destinationPoint;
        private string _destinationTime;
        private List<int> _tickets;

        public string Number
        {
            get { return _number; }
            set { if (value != null) _number = value; }
        }

        public int DeparturePoint
        {
            get { return _departurePoint; }
            set { if (value > 0) _departurePoint = value; }
        }

        public string DepartureTime
        {
            get { return _departureTime; }
            set { if (value != null) _departureTime = value; }
        }

        public int DestinationPoint
        {
            get { return _destinationPoint; }
            set { if (value > 0) _destinationPoint = value; }
        }

        public string DestinationTime
        {
            get { return _destinationTime; }
            set { if (value != null) _destinationTime = value; }
        }

        public List<int> Tickets
        {
            get { return _tickets; }
            set { if (value != null) _tickets = value; }
        }
    }
}
