using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Flight
    {
        public int FlightID;
        public DateOnly DateOfFlight;
        public string Destination;
        public decimal BusinessPrice;
        public decimal EconomyPrice;
        public List<Seat> Seating { get; }
        public bool currentStatus { get; }

        // source airport
        // destination airport

        public Flight()
        {
            FlightID = 0;

        }

        public decimal GetPrice(int seatNumber)
        {
            decimal price = 0;
            return price;

        }

        public List<Flight> HasAvailableSeats(int flightID)
        {
            List<Flight> flights = new List<Flight>();
            return flights;

        }
    }
}
