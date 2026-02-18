using AirlineReservationSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Models
{
    public class Airplane : IHasID
    {
        public int ID { get; set; }

        // Navigation Properties mit Foreign Keys
        public int FlightID { get; set; }
        public Flight Flight { get; set; } = null!;

        
        // TODO: Attribute überarbeiten

        public string Name { get; set; } = string.Empty;
        public List<Seat> AirplaneSeats { get; set; } = null!;
        //public BusinessClass BusinessClass { get; set; }
        //public EconomyClass EconomyClass { get; set; }

        public Airplane() { }

        public Airplane(int airplaneID, string name) 
        {
            ID = airplaneID;
            AirplaneSeats = new List<Seat>();
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
            return AirplaneSeats;
        }
        
        // bool überschreiben? business / economy
    }
}
