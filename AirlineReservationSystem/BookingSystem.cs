using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class BookingSystem
    {
        List<Customer> Customer { get; }
        List<Flight> Flight { get; }
        List<Reservation> Reservation { get; }
        List<Airplane> Airplane { get; }
        
        public BookingSystem() 
        { 
            
        }

        public decimal GetPrice(SeatClass seatClass)
        {
            decimal price = 0;
            return price;
        }

        public List<Seat> HasAvailableSeats()
        {
            List<Seat> availableSeats = new List<Seat>();
            return availableSeats;
        }

        public List<Seat> GetSeats()
        {
            List<Seat> flightSeats = new List<Seat>();
            return flightSeats;
        }
    }
}
