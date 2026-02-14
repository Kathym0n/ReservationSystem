using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Utilities
    {
        
        public static int CreateNewID<T>(List<T> items) where T : IHasID
        {
            int maxID = 0;
            foreach (var item in items)
            {
                if (item.ID > maxID)
                {
                    maxID = item.ID;
                }
            }
            return maxID+1;
        }
    }
}
