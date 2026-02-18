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

        // Navigation Properties mit Foreign Keys
        public int FlightID { get; set; }
        public Flight Flight { get; set; } = null!;
        public int ReservationID { get; set; }
        public Reservation Reservation { get; set; } = null!;

        
        // TODO: Attribute überarbeiten

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //public string Password;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();


        public Customer() { }

        public Customer(string name)
        {
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
