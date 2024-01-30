using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Lamp lamp = new Lamp("Room decoration", 15, "Brown", "Glass");

            Console.WriteLine(lamp.getLampInfo());
        }
    }
}  