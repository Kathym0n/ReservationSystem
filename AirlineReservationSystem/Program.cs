namespace AirlineReservationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Reservierungssystem für Ihren Flug!");
            
            BookingSystem TestSystem = new BookingSystem();
            Airplane Test = TestSystem.CreateAirplane("Kathys Jet");
            Airplane Test2 = TestSystem.CreateAirplane("Felix' Jet");
            Console.WriteLine(Test);
            Console.WriteLine(Test2);
            List<int> testRows = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            List<char> testColumns = new List<char>
            {
                'A', 'B', 'C'
            };
            Test.CreateSeats(testRows, testColumns, SeatClass.Economy);
            foreach (var seat in Test.Seats)
            {
                Console.WriteLine(seat);
            }
            Flight testFlight = TestSystem.CreateFlight(Test, Airports.MUC, Airports.AMS);
            Test.Seats[0].SeatClass = SeatClass.Business;
            foreach (var seat in testFlight.Seats)
            {
                Console.WriteLine(seat);
            }
            foreach (var seat in Test.Seats)
            {
                Console.WriteLine(seat);
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

