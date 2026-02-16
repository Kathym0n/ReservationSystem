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
        public Airports DepartureAirport {  get; set; }
        public Airports ArrivalAirport { get; set; }
        public DateOnly DateOfFlight;
        public decimal BusinessPrice;
        public decimal EconomyPrice;
        public List<Seat> Seats { get; }
        public bool CurrentStatus { get; }


        public Flight(int id, Airplane plane, Airports departureCode, Airports arrivalCode)
        {
            ID = id;
            Plane = plane;
            DepartureAirport = departureCode;
            ArrivalAirport = arrivalCode;
            Seats = plane.Seats;

            DateOfFlight = new DateOnly();
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
