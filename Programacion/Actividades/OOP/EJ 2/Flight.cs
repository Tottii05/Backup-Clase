using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pruebas
{
    internal class Flight
    {
        private int idPilot, timeFlight;
        private string airLine;

        public int IdPilot { get { return idPilot; } set { idPilot = value; } }
        public int TimeFlight { get {  return timeFlight; } set {  timeFlight = value; } }
        public string AirLine { get {  return airLine; } set {  airLine = value; } }
    }
}
