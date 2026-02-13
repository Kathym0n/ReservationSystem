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
        
        /// <summary>
        /// Initializes a new instance of the Reservation class.
        /// </summary>
        public Reservation() 
        { 
            
        }

        public void ConfirmReservation()
        {

        }

        public void CancelReservation() 
        { 
        
        }
    }
}
