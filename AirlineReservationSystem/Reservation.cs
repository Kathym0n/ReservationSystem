using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    /// <summary>
    /// Represents a reservation containing flight, customer, and seat information.
    /// </summary>
    public class Reservation
    {
        Reservation ReservationID;
        Flight FlightID;
        Customer CustomerID;
        List<Seat> Seats;
        
        /// <summary>
        /// 
        /// </summary>
        public Reservation() 
        { 
            ReservationID = new Reservation();
            FlightID = new Flight();
            CustomerID = new Customer();
            Seats = new List<Seat>();
            
        }

        public void ConfirmReservation()
        {

        }

        public void CancelReservation() 
        { 
        
        }
    }
}
