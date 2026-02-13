using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public interface IBookable
    {
        bool Reserve(); // Sitz vorrübergehend blockieren
        
        bool Book();    // Sitz endgültig Customer zuordnen

        // Status-Management: frei/reserviert/gebucht
    }
}
