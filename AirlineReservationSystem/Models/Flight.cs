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

        // Foreign Key: which airplane?
        public int AirplaneID { get; set; }
        public Airplane Airplane { get; set; } = null!;

        public Airports DepartureAirport {  get; set; }
        public Airports ArrivalAirport { get; set; }
        public DateOnly DateOfFlight { get; set; }
        public decimal BusinessPrice { get; set; }
        public decimal EconomyPrice { get; set; }
        public bool CurrentStatus { get; set; }
        
        // Navigation
        public List<FlightSeat> FlightSeats { get; set; } = new List<FlightSeat>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        
        public Flight() { }

        public Flight(Airplane airplane, Airports departureCode, Airports arrivalCode)
        {
            Airplane = airplane;
            DepartureAirport = departureCode;
            ArrivalAirport = arrivalCode;
            DateOfFlight = DateOnly.FromDateTime(DateTime.Now);
        }


        // TODO: Methoden
        public decimal GetPrice(int seatNumber)
        {
            decimal price = 0;
            return price;

        }
    }
}
