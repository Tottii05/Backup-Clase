using System;

namespace Pruebas
{
    public abstract class WheeledVehicle : Vehicle
    {
        public int CantWheels { get; set; }
        public string Brand { get; set; }

        public WheeledVehicle (int cantWheels, string brand, int wheels, int topSpeed, bool motored) : base(wheels, topSpeed, motored)
        {
            CantWheels = cantWheels;
            Brand = brand;
        }
    }
}
