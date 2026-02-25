using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineReservationSystem.Models
{
    public class ReservationSeat : IHasID
    {
        public int ID { get; set; }

        //Foreign Key: which reservation?
        public int ReservationID { get; set; }
        public Reservation Reservation { get; set; } = null!;
        //Foreign Key: which FlightSeat?
        public int FlightSeatID { get; set; }
        public FlightSeat FlightSeat { get; set; } = null!;

        public ReservationSeat() { }
    }
}
