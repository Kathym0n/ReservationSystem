using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    struct Airplane
    {
        public int AirplaneID;
        public List<Seat> Seats;

        public Airplane() 
        {
            
        }

        public List<Seat> GetSeats()
        {
            return Seats;
        }
    }
}
