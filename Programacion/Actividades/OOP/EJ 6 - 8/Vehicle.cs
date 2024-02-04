using System;

namespace Pruebas
{
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
        public int TopSpeed { get; set; }
        public bool Motored { get; set; }

        public Vehicle(int wheels, int topSpeed, bool motored)
        {
            Wheels = wheels;
            TopSpeed = topSpeed;
            Motored = motored;
        }
    }
}
