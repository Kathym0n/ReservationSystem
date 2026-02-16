using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class BookingSystem
    {
        List<Airplane> Airplanes { get; set; }
        List<Flight> Flights { get; }
        List<Customer> Customers { get; }
        List<Reservation> Reservations { get; set; }
        
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
        public Flight CreateFlight(Airplane airplane, Airports departure, Airports arrival)
        {
            int id = Utilities.CreateNewID(Flights);
            Flight newFlight = new Flight(id, airplane, departure, arrival);
            Flights.Add(newFlight);
            return newFlight;
        }
        public Customer CreateCustomer(string name)
        {
            int id = Utilities.CreateNewID(Customers);
            Customer newCustomer = new Customer(id, name);
            Customers.Add(newCustomer);
            return newCustomer;
        }
        public Reservation CreateReservation(Customer customer, Flight flight, List<Seat> seats)
        {
            int id = Utilities.CreateNewID(Reservations);
            Reservation newReservation = new Reservation(id, customer, flight, seats);
            Reservations.Add(newReservation);
            return newReservation;
        }


        // TODO: Methoden

        //public List<Flight> GetFlights()
        //{
        //    List<Flight> flightsAll = new List<Flight>(); 
        //    List<Flight> Flights;
        //}
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
