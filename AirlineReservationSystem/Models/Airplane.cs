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
        public List<Seat> Seats { get; set; } = new List<Seat>();
        public List<int> FlightID { get; set; } = new List<int>();
        public List<Flight> Flights { get; set; } = new List<Flight>();

        
        // TODO: Attribute überarbeiten

        public string Name { get; set; } = string.Empty;
        //public BusinessClass BusinessClass { get; set; }
        //public EconomyClass EconomyClass { get; set; }

        public Airplane() 
        {
            Flights = new List<Flight>();
            Seats = new List<Seat>();
            Name = string.Empty;
        }

        public Airplane(int airplaneID, string name) 
        {
            ID = airplaneID;
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
            return AirplaneSeats;
        }
        
        // TODO: bei Anpassung der Sitze: bool SeatClass überschreiben? business / economy
    }
}
