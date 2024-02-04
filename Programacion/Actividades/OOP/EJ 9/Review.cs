using System;

namespace Pruebas
{
    public class Review : Stationery
    {
        public Review(string name, string description, string publicDate, int edition, int cantPages, string autor, string type) : base(name, description, publicDate, edition, cantPages, autor, type) { }
    }
}
