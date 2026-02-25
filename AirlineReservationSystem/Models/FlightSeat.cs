using AirlineReservationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineReservationSystem.Models
{
    public class FlightSeat : IHasID
    {
        public int ID { get; set; }
        
        // Foreign Key: which flight?
        public int FlightID { get; set; }
        public Flight Flight { get; set; }

        // Foreign Key: which physical location?
        public int SeatID { get; set; }
        public Seat Seat { get; set; }

        // Status of one flight!
        public SeatStatus Status { get; set; } = SeatStatus.Free;

        public FlightSeat() { }
    }

}
