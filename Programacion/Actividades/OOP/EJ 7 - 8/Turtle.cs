using System;

namespace Pruebas
{
    public class Turtle : Reptile
    {
        public string Feeding {  get; set; }

        public Turtle (string feeding, bool armored, int weight, int size, string breed) : base(armored, weight, size, breed)
        {
            Feeding = feeding;
        }
    }
}
