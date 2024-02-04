using System;

namespace Pruebas
{
    public class Iguana : Reptile
    {
        public string Color { get; set; }

        public Iguana(string color, bool armored, int weight, int size, string breed) : base(armored, weight, size, breed)
        {
            Color = color;
        }
    }
}
