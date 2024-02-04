using System;

namespace Pruebas
{
    public abstract class Animal
    {
        public int Weight {  get; set; }
        public int Size { get; set; }
        public string Breed { get; set; }

        public Animal(int weight, int size, string breed)
        {
            Weight = weight;
            Size = size;
            Breed = breed;
        }
    }
}
