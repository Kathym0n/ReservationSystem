using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Reservation
    {
        // Verknüpfung: Customer, Flight, Seating
        Customer customer;
        Flight flight;
        Seating Seating { get; set; }
        

        public Reservation() { }

        public void ConfirmReservation()
        {

        }

        public void CancelReservation() 
        { 
        
        }
    }
}
