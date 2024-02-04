using System;

namespace Pruebas
{
    public class Coupe : Car
    {
        public int CmTrunk {  get; set; }

        public Coupe (int cmTrunk, int cantDoors, int cantWheels, string brand, int wheels, int topSpeed, bool motored) : base(cantDoors, cantWheels, brand, wheels, topSpeed, motored)
        {
            CmTrunk = cmTrunk;
        }
    }
}
