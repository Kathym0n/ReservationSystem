using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class BusinessClass
    {
        public List<int> Rows { get; set; }
        public List<char> Columns { get; set; }

        public BusinessClass(List<int> rows, List<char> columns)
        {
            Rows = rows; 
            Columns = columns;
        }

        public BusinessClass CreateBusinessClass(List<int> rows, List<char> columns)
        {
            return new BusinessClass(Rows, Columns);
        }

    // TODO: Methoden bzgl. Vergabe von Reihen und Spalten?


        public List<int> rows = new List<int>
        {
            1, 2, 3, 4, 5, 6
        };

        public List<char> columns = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F'
        };
    }
}
