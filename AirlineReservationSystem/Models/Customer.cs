using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public class Customer : IHasID
    {

        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAdress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        // Navigation
        public List<Reservation> Reservations { get; set; }

        // TODO: Attribute erweitern?
        //public string Password;
        //public string Address { get; set; } = string.Empty;

        public Customer() { }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{ID}, {FirstName} {LastName}";
        }

        // TODO: Methoden
        public void ReserveSeating(Flight flightID, Seat seatNumber)
        {

        }

        public void BookFlight(int flightID)
        {

        }

    }
}
