using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class BookingSystem
    {
        List<Customer> Customers { get; }
        List<Flight> Flights { get; }
        List<Reservation> Reservations { get; }
        List<Airplane> Airplanes { get; set; }
        
        public BookingSystem() 
        {
            Customers = new List<Customer>();
            Flights = new List<Flight>();
            Reservations = new List<Reservation>();
            Airplanes = new List<Airplane>();
        }

        public Airplane CreateAirplane(string name)
        {
            int id = Utilities.CreateNewID(Airplanes);
            Airplane newAirplane = new Airplane(id, name);
            Airplanes.Add(newAirplane);
            return newAirplane;
        }

        public decimal GetPrice(SeatClass seatClass)
        {
            decimal price = 0;
            return price;
        }

        public List<Seat> HasAvailableSeats()
        {
            List<Seat> availableSeats = new List<Seat>();
            return availableSeats;
        }

        public List<Seat> GetSeats()
        {
            List<Seat> flightSeats = new List<Seat>();
            return flightSeats;
        }
    }
}
