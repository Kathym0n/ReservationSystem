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

        // Foreign Key: which customer?
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        // Foreign Key: which flight?
        public int FlightID { get; set; }
        public Flight Flight { get; set; } = null!;

        public List<ReservationSeat> ReservationSeats { get; set; } = new List<ReservationSeat>();

        public Reservation() { }

        // TODO: Methoden
        public void ConfirmReservation()
        {

        }

        public void CancelReservation() 
        { 
        
        }
    }
}
