using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Enums
{
    internal class FlightStatus
    {
        public enum Type
        {
            Scheduled,
            Boarding,
            Departed,
            Arrived,
            Cancelled
        }
    }
}
