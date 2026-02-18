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
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //public string Password;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Reservation> Reservations { get; set; }


        public Customer() { }

        public Customer(int customerID, string name)
        {
            ID = customerID;
            Name = name;
            Email = string.Empty;
            PhoneNumber = string.Empty; 
            Address = string.Empty;
            Reservations = new List<Reservation>();
        }

        public override string ToString()
        {
            return $"{ID}, {Name}";
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
