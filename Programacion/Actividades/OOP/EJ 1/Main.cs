using prueba;
using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.Name = "Tomas";
            person.LastName = "Vicente";
            person.Age = 18;

            Console.WriteLine(person.Name + " " + person.LastName + " " + person.Age);
        }
    }
}
