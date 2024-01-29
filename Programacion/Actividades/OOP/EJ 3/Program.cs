using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Bike bike = new Bike();
            bike.Color = "Azul";
            bike.Type = "Montaña";
            bike.Gears = 6;
            
            Console.WriteLine(bike.Color + " " + bike.Type + " " + bike.Gears);
        }
    }
}