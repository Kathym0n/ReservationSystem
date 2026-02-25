using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public class Reservation : IHasID
    {
        public int ID { get; set; }

        // Navigation Properties mit Foreign Keys
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;
        public int FlightID { get; set; }
        public Flight Flight { get; set; } = null!;
        public List<string> SeatID { get; set; } = new List<string>();
        public List<Seat> Seats { get; set; } = new List<Seat>();

        // TODO: Attribute überarbeiten?


        public Reservation() 
        { 
            Seats = new List<Seat>();
        }

        public Reservation(int reservationID, Customer customer, Flight flight, List<Seat> seats) 
        {
            ID = reservationID;
            Customer = customer;
            Flight = flight;
            Seats = seats;
            
        }

        // TODO: Methoden
        public void ConfirmReservation()
        {

        }

        public void CancelReservation() 
        { 
        
        }
    }
}
