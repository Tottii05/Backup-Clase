using System;

namespace Pruebas
{
    public class Car : WheeledVehicle
    {
        public int CantDoors { get; set; }

        public Car (int cantDoors, int cantWheels, string brand, int wheels, int topSpeed, bool motored) : base(cantWheels, brand, wheels, topSpeed, motored)
        {
            CantDoors = cantDoors;
        }
    }
}
