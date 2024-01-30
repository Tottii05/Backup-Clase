using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Card card = new Card("Escoba de 15", 7, "oros");

            Console.WriteLine(card.getCardInfo());
        }
    }
}  