using AirlineReservationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    /// <summary>
    /// only physical seat definition
    /// </summary>
    public class Seat : IHasID
    {
        public int ID { get; set; }

        /// <summary>
        /// Foreign Key: only Airplane
        /// </summary>
        public int AirplaneID { get; set; }
        public Airplane Airplane { get; set; } = null!;

        /// <summary>
        /// Attributes
        /// </summary>
        public string SeatNumber { get; set; } = string.Empty; 
        public int SeatRow { get; set; }
        public string SeatColumn { get; set; } = string.Empty;
        public SeatClass SeatClass { get; set; }

        public List<FlightSeat> FlightSeats { get; set; } = new List<FlightSeat>();

        public Seat() { }

        public Seat(int row, char seatColumn, SeatClass seatClass)
        {
            SeatRow = row;
            SeatColumn = $"{seatColumn}";
            SeatNumber = $"{row}{seatColumn}";
            SeatClass = seatClass;
        }

        public override string ToString()
        {
            return $"{SeatRow}{SeatColumn} ({SeatClass})";
        }

        //public Seat Clone()
        //{
        //    return new Seat; // Seat Column char
        //}

        // TODO: Methoden
        public void Reserve()
        {

        }

        public void Book()
        {

        }

        public bool IsReserved()
        {
            bool status = true;
            return status;
        }

        public bool IsBooked()
        {
            bool status = true;
            return status;
        }

    }
}
