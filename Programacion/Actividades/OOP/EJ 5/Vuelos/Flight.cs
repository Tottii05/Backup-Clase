using System;

namespace Pruebas
{
    public class Flight : Airline
    {
        private string loc_destination;
        private string loc_initial;
        private int duration;

        public string Loc_destination { get { return loc_destination; } set { loc_destination = value; } }
        public string Loc_inital { get { return loc_initial; } set { loc_initial = value; } }
        public int Duration { get { return duration; } set { duration = value; } }

        public Flight (int airline_id, string loc_destination, string loc_initial, int duration) : base (airline_id)
        {
            Loc_destination = loc_destination;
            Loc_inital = loc_initial;
            Duration = duration;
        }

        public void getFlightInfo()
        {
            Console.WriteLine (Airline_id + " " + Loc_destination + " " + Loc_inital + " " +  Duration);
        }
    }
}