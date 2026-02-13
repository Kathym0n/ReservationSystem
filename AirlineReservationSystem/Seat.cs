using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Seat :IBookable
    {
        public int Row;
        public int MaxRow = 30;
        public string SeatLetter;
        public char MaxLetter = 'F';
        public bool Status;
        // seatClass;

        public Seat(int row, char seatLetter)
        {
            Row = row;
            SeatLetter = $"{seatLetter}";
            string seatNumber = $"{row}{seatLetter}";
        }

        public List<string> GetSeats(int maxRow, char maxLetter) 
        {
            List<string> seatList = new List<string>();
            string seatNumber;

            for (int i = 1; i <= maxRow; i++)
            {
                for (char j = 'A'; j <= maxLetter; j++)
                {
                    seatNumber = $"{i}{j}";
                    seatList.Add(seatNumber);
                }
            }
            return seatList;
        }

        public void Reserve()
        {

        }

        public void Book()
        {

        }

        public bool IsReserved()
        {
            return Status;
        }

        public bool IsBooked()
        {
            return Status;
        }

    }
}
