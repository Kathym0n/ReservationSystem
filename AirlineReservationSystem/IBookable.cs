using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public interface IBookable
    {
        void Reserve(); // Sitz vorrübergehend blockieren

        void Book();    // Sitz endgültig Customer zuordnen

        bool IsReserved(); // Sitz auf Reservierung prüfen
        
        bool IsBooked();    // Sitz aud Buchung prüfen

        // TODO: Status-Management: frei/reserviert/gebucht
    }
}
