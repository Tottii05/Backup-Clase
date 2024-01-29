using System;

namespace Pruebas
{
    internal class Card
    {
        private string color, type;
        private int number;

        public string Color { get { return color; } set {  color = value; } }
        public int Number { get { return number; } set { number = value; } }
        public string Type { get { return type; } set {  type = value; } }
    }
}
