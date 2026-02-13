using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Flight
    {
        public int flightID;
        public DateOnly dateOfFlight;
        public string destination;
        public decimal businessPrice;
        public decimal economyPrice;
        public List<Seating> GetSeatings {  get; set; }
        public FlightStatus currentStatus { get; set; } 

        // string flightNumber;
        // date of flight
        // launch time
        // destination time
        // source airport
        // destination airport

        public decimal GetPrice(SeatClass seatClass)
        {
            if (SeatClass.Type == "Business")
            {

            }
        }
    }
}
