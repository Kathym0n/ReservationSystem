namespace AirlineReservationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Reservierungssystem für Ihren Flug!");
            Seat testSeating = new Seat(1, 'F');

            foreach (var item in testSeating.GetSeats(30, 'F'))
            {
                Console.WriteLine($"{item}");
            }
            BookingSystem TestSystem = new BookingSystem();
            Airplane Test = TestSystem.CreateAirplane("Kathys Jet");
            Airplane Test2 = TestSystem.CreateAirplane("Felix' Jet");
            Console.WriteLine(Test);
            Console.WriteLine(Test2);

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

