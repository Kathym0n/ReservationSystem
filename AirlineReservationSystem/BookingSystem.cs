using AirlineReservationSystem.Enums;
using AirlineReservationSystem.Models;
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
            Airplane newAirplane = new Airplane(name);
            Airplanes.Add(newAirplane);
            return newAirplane;
        }
        public Flight CreateFlight(Airplane airplane, Airports departureCode, Airports arrivalCode)
        {
            Flight newFlight = new Flight(airplane, departureCode, arrivalCode);
            Flights.Add(newFlight);
            return newFlight;
        }
        public Customer CreateCustomer(string firstName, string lastName)
        {
            Customer newCustomer = new Customer(firstName,lastName);
            Customers.Add(newCustomer);
            return newCustomer;
        }
        public Reservation CreateReservation(Customer customer, Flight flight)
        {
            Reservation newReservation = new Reservation();
            newReservation.Customer = customer;
            newReservation.Flight = flight;
            Reservations.Add(newReservation);
            return newReservation;
        }


        // TODO: Methoden

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
