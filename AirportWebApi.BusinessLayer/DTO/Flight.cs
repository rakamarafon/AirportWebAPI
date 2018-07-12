using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.DTO
{
    public class Flight : BaseObject
    {
        private string _number;             
        private Point _departurePoint;
        private string _departureTime;
        private Point _destinationPoint;
        private string _destinationTime;
        private List<Ticket> _tickets;

        public string Number
        {
            get { return _number; }
            set { if (value != null) _number = value; }
        }

        public Point DeparturePoint
        {
            get { return _departurePoint; }
            set { if (value != null) _departurePoint = value; }
        }

        public string DepartureTime
        {
            get { return _departureTime; }
            set { if (value != null) _departureTime = value; }
        }

        public Point DestinationPoint
        {
            get { return _destinationPoint; }
            set { if (value != null) _destinationPoint = value; }
        }

        public string DestinationTime
        {
            get { return _destinationTime; }
            set { if (value != null) _destinationTime = value; }
        }

        public List<Ticket> Tickets
        {
            get { return _tickets; }
            set { if (value != null) _tickets = value; }
        }
    }
}
