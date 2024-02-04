using System;

namespace Pruebas
{
    public class Journal : Stationery
    {
        public Journal(string name, string description, string publicDate, int edition, int cantPages, string autor, string type) : base(name, description, publicDate, edition, cantPages, autor, type) { }
    }
}
