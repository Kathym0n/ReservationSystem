using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class EconomyClass
    {
        // TODO: Methoden bzgl. Vergabe von Reihen und Spalten

        public EconomyClass() 
        {
            
        }
        
        List<int> row = new List<int>
        {
            7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
        };

        List<char> column = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F'
        };
    }
}
