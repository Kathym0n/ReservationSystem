using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Customer 
    {

        public int customerID;
        public string name;
        public string email;
        public string phoneNumber;
        public string address;
        public List<Reservation> reservations { get; }


        //string password;


        public void ReserveSeating()
        {

        }

        public void BookFlight(int flightID)
        {

        }

    }
}
