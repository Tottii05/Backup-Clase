using System;

namespace Pruebas
{
    public class Card
    {
        private string color, type;
        private int number;

        public string Color { get { return color; } set { color = value; } }
        public int Number { get { return number; } set { number = value; } }
        public string Type { get { return type; } set { type = value; } }
    }

    public class Deck : Card
    {
        private int totalCards;

        public int TotalCards { get { return totalCards; } set { totalCards = value; } }

        // Constructor para inicializar el total de cartas en el mazo y las propiedades de la carta
        public Deck(int initialTotalCards, string color, int number, string type)
        {
            TotalCards = initialTotalCards;
            Color = color;
            Number = number;
            Type = type;
        }
    }
}