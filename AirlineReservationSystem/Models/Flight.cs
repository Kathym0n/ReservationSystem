using AirlineReservationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public class Flight : IHasID
    {
        public int ID { get; set; }

        // Navigation Properties mit Foreign Keys
        public int AirplaneID { get; set; }
        public Airplane Airplane { get; set; } = null!;
        public List<Seat> FlightSeats { get; set; } = new List<Seat>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();


        // TODO: Attribute überarbeiten

        public Airports DepartureAirport {  get; set; }
        public Airports ArrivalAirport { get; set; }
        public DateOnly DateOfFlight;
        public decimal BusinessPrice;
        public decimal EconomyPrice;
        public bool CurrentStatus { get; }

        public Flight() { }

        public Flight(int id, Airplane airplane, Airports departureCode, Airports arrivalCode)
        {
            ID = id;
            Airplane = airplane;
            DepartureAirport = departureCode;
            ArrivalAirport = arrivalCode;
            FlightSeats = airplane.AirplaneSeats;

            DateOfFlight = new DateOnly();
            //CurrentStatus = GetStatus(id);


            // TODO: neue Tabelle: Airports - Ortsname ?
            // Origin
            // Destination
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
