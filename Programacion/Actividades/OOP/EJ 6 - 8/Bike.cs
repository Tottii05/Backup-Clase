using System;

namespace Pruebas
{
    public class Bike : WheeledVehicle
    {
        public string Type { get; set; }

        public Bike(string type, int wheels, int topSpeed, bool motored) : base(wheels, topSpeed, motored)
        {
            Type = type;
        }
    }
}
