using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Flight flight = new Flight(101, "Barcelona", "Buenos Aires", 12);

            flight.getFlightInfo();
        }
    }
}  