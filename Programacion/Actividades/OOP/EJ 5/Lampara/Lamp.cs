using System;

namespace Pruebas
{
    public class Lamp : Furniture
    {
        private string color, material;
        private int height;

        public int Height { get { return height; } set { height = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Material { get { return material; } set { material = value; } }

        // Constructor de la subclase Card que toma el argumento gameType y lo pasa al constructor de la clase base
        public Lamp(string furnitureType, int height, string color, string material) : base(furnitureType)
        {
            Height = height;
            Color = color;
            Material = material;
        }

        public string getLampInfo()
        {
            return FurnitureType + " " + Height + " " + Material + " " + Color;
        }
    }
}