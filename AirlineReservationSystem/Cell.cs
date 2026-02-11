using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public struct Cell
    {
        /// <summary>
        /// 
        /// </summary>
        public int Row { get; }
        public char Column { get; }

        /// <summary>
        /// Initializes a new instance of the Cell class with the specified row and column.
        /// </summary>
        /// <param name="row">The row index of the cell.</param>
        /// <param name="column">The column character of the cell.</param>
        public Cell(int row, char column)
        {
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Returns a string that concatenates the Row and Column values.
        /// </summary>
        /// <returns>A string representation of the object in the format of Row followed by Column.</returns>
        public override string ToString()
        {
            return $"{Row}{Column}";
        }
    }
}
