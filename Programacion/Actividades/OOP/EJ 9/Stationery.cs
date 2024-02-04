﻿using System;

namespace Pruebas
{
    public abstract class Stationery
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PublicDate { get; set; }
        public int Edition {  get; set; }
        public int CantPages { get; set; }
        public string Autor {  get; set; }
        public string Type { get; set; }

        public bool CheckAutor()
        {
            return Autor == null;
        }

        public void Throw() { Console.WriteLine("The {0} flies away", Name); }

        public Stationery(string name, string description, string publicDate, int edition, int cantPages, string autor, string type)
        {
            Name = name;
            Description = description;
            PublicDate = publicDate;
            Edition = edition;
            CantPages = cantPages;
            Autor = autor;
            Type = type;
        }
    }
}