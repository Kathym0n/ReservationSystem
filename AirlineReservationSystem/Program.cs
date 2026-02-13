namespace AirlineReservationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Reservierungssystem für Ihren Flug!");
            Seating testSeating = new Seating();

            foreach (var item in testSeating.GetSeats(30, 'F'))
            {
                Console.WriteLine($"{item}");
            }

            //Console.WriteLine("Geben Sie die FlugID an: ");
            //string FlugID = Console.ReadLine();
            //Console.WriteLine($"Vielen Dank. Bei Flug {FlugID} haben Sie die Wahl aus den folgenden freien Sitzen: ");
            //Console.WriteLine(Seating( FlugID ));
        
        }

        // TODO: Get input
        // TODO: Process data
        // TODO: Output result

        }
}

