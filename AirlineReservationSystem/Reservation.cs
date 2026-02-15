using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Reservation : IHasID
    {
        public int ID { get; set; }
        public Customer Customer;
        public Flight Flight;
        public List<Seat> Seats;
        

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
