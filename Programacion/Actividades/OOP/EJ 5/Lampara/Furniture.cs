using System;

namespace Pruebas
{
    public class Furniture
    {
        private string furnitureType;

        public string FurnitureType { get { return furnitureType; } set { furnitureType = value; } }

        public Furniture(string furnitureType)
        {
            FurnitureType = furnitureType;
        }
    }
}
