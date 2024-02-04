using System;

namespace Pruebas
{
    public abstract class Reptile : Animal
    {
        public bool Armored { get; set; }

        public Reptile (bool armored, int weight, int size, string breed) : base (weight, size, breed)
        {
            Armored = armored;
        }
    }
}
