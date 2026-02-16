using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class EconomyClass
    {
        public List<int> Rows { get; set; }
        public List<char> Columns { get; set; }

        public EconomyClass(List<int> rows, List<char> columns)
        {
            Rows = rows;
            Columns = columns;
        }
        public EconomyClass CreateEconomyClass(List<int> rows, List<char> columns)
        {
            return new EconomyClass(Rows, Columns);
        }

        // TODO: Methoden bzgl. Vergabe von Reihen und Spalten?

       public  List<int> rows = new List<int>
        {
            7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
        };

        public List<char> columns = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F'
        };
    }
}
