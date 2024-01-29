using System;

namespace Pruebas
{
    internal class Bike
    {
        private string color, type;
        private int gears;

        public string Color { get { return color; } set {  color = value; } }
        public string Type { get { return type; } set {  type = value; } }
        public int Gears { get {  return gears; } set {  gears = value; } }
        
    }
}
