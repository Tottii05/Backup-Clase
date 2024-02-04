using System;

namespace Pruebas
{
    public class Wolf : Animal
    {
        public bool Alfa {  get; set; }

        public Wolf (bool alfa, int weight, int size, string breed) : base(weight, size, breed)
        {
            Alfa = alfa;
        }
    }
}
