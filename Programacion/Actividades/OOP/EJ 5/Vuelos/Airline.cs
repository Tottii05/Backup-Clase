using System;

namespace Pruebas
{
    public class Airline
    {
        private int airline_id;

        public int Airline_id { get { return airline_id; } set { airline_id = value; } }

        public Airline(int airline_id)
        {
            Airline_id = airline_id;
        }
    }
}
