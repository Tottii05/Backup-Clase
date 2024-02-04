using System;

namespace Pruebas
{
    public class Sedan : Car
    {
        public int CantPassengers { get; set; }

        public Sedan (int cantPassengers, int cantDoors, int cantWheels, string brand, int wheels, int topSpeed, bool motored) : base(cantDoors, cantWheels, brand, wheels, topSpeed, motored)
        {
            CantPassengers = cantPassengers;
        }
    }
}
