using System;

namespace Pruebas
{
    public class Card : CardGame
    {
        private string color, type;
        private int number;

        public int Number { get { return number; } set { number = value; } }
        public string Type { get { return type; } set { type = value; } }

        // Constructor de la subclase Card que toma el argumento gameType y lo pasa al constructor de la clase base
        public Card(string gameType, int number, string type) : base(gameType)
        {
            Number = number;
            Type = type;
        }

        public string getCardInfo()
        {
            return GameType + " " + Number + " " + Type;
        }
    }
}