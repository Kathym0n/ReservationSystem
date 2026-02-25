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
        public string Name { get; set; } = string.Empty;

        // Navigation
        public List<Seat> Seats { get; set; } = new List<Seat>();
        public List<Flight> Flights { get; set; } = new List<Flight>();


        public Airplane() { }

        public Airplane(string name) 
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} {ID}";
            ;
        }

        public List<Seat> CreateSeats(List<int> rows, List<char> columns, SeatClass seatClass)
        {
            foreach (int row in rows)
            {
                foreach (char column in columns)
                {
                    Seat newSeat = new Seat(row, column, seatClass);
                    Seats.Add(newSeat);
                }
            }
            return Seats;
        }
        
        // TODO: bei Anpassung der Sitze: bool SeatClass überschreiben? business / economy
    }
}
