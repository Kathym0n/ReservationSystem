using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Flight : IHasID
    {
        public int ID { get; set; }
        public Airplane Plane { get; set; }
        public string DepartureAirport {  get; set; }
        public string ArrivalAirport { get; set; }
        public DateOnly DateOfFlight;
        public decimal BusinessPrice;
        public decimal EconomyPrice;
        public List<Seat> Seating { get; }
        public bool CurrentStatus { get; }

        //public string Origin { get; set; }
        //public string Destination {  get; set; }

        public Flight(int id, Airplane plane, string departure, string arrival)
        {
            ID = id;
            Plane = plane;
            DepartureAirport = departure;
            ArrivalAirport = arrival;

            DateOfFlight = new DateOnly();
            Seating = new List<Seat>();
            //CurrentStatus = GetStatus(id);

            //Origin = origin;
            //Destination = destination;
        }



        // TODO: Methoden
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
