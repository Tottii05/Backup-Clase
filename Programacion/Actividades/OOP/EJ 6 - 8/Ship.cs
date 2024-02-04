using System;

namespace Pruebas
{
    public class Ship : Vehicle
    {
        public bool IsSailBoat { get; set; }
        public string Name { get; set; }

        public Ship (bool isSailBoat, string name, int wheels, int topSpeed, bool motored) : base(wheels, topSpeed, motored)
        {
            IsSailBoat = isSailBoat;
            Name = name;
        }
    }
}
