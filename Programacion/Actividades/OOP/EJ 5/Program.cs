using Pruebas;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Deck myDeck = new Deck();

            // Utilizar los setters para asignar valores
            myDeck.Color = "Rojo";
            myDeck.Number = 5;
            myDeck.Type = "Número";
            myDeck.TotalCards = 32;

            Console.WriteLine("Hola");

        }
    }
}


/*
 Deck deck = new Deck(32, "Verde", 3, "Normal"); */