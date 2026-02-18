using AirlineReservationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Seat :IBookable  //, ICloneable
    {
        public int ID { get; set; }
        public string SeatNumber; 
        public int SeatRow;
        public string SeatColumn;
        public SeatStatus Status;
        public SeatClass SeatClass { get; set; }

        public Seat() { }

        public Seat(int row, char seatColumn, SeatClass seatClass)
        {
            SeatRow = row;
            SeatColumn = $"{seatColumn}";
            string seatNumber = $"{row}{seatColumn}";
            SeatNumber = seatNumber;
            Status = SeatStatus.Free;
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
