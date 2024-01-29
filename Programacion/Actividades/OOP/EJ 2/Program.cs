using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Card card = new Card();
            card.Color = "Red";
            card.Type = "Normal";
            card.Number = 7;
            
            Console.WriteLine(card.Color + " " + card.Type + " " + card.Number);

            Lamp lamp = new Lamp();
            lamp.Material = "Madera";
            lamp.Type = "Gótica";
            lamp.Conection = "Cable";

            Console.WriteLine(lamp.Material + " " + lamp.Type + " " + lamp.Conection);

            Flight flight = new Flight();
            flight.AirLine = "Iberdrola";
            flight.TimeFlight = 8;
            flight.IdPilot = 101;

            Console.WriteLine(flight.AirLine + " " + flight.TimeFlight + " " + flight.IdPilot);
        }
    }
}