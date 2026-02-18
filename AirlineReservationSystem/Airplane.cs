using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Airplane : IHasID
    {
        public int ID { get; set; }
        public List<Seat> Seats;
        public string Name;
        //public BusinessClass BusinessClass { get; set; }
        //public EconomyClass EconomyClass { get; set; }

        public Airplane(int planeID, string name) 
        {
            ID = planeID;
            Seats = new List<Seat>();
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} {ID}";
            ;
        }

        public List<Seat> CreateSeats(List<int> rows, List<char> columns, SeatClass seatClass)
        {
            List<Seat> newSeats = new List<Seat>();
            foreach (int row in rows)
            {
                foreach (char column in columns)
                {
                    Seat newSeat = new Seat(row, column, seatClass);
                    newSeats.Add(newSeat);
                }
            }
            //Seats.AddRange(newSeats); // Validierung optional hinzufügen
            //Seats.Select(A => new Seat(A.Row, A.SeatColumn, seatClass));
            return Seats;
        }
        // bool überschreiben? business / economy
    }
}
