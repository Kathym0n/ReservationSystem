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
        public List<int> ReservationID { get; set; } = new List<int>();
        public List<Reservation> Reservations { get; set; }


        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAdress { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        

        // TODO: Attribute überarbeiten

        //public string Password;
        //public string Address { get; set; } = string.Empty;

        public Customer() 
        { 
            Reservations = new List<Reservation>();
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = string.Empty;
            PhoneNumber = string.Empty; 
            Reservations = new List<Reservation>();

            //Address = string.Empty;
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
