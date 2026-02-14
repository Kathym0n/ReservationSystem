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

        public List<Seat> GetSeats()
        {
            return Seats;
        }
    }
}
