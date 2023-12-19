using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce el número para ser la base de la potencia";
            const string Exponent = "Introduce el número para ser el exponente de la potencia";


            int Base, exponent;


            Console.WriteLine(Start);
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Exponent);
            exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Base} elevado a {exponent} es: {Math.Pow(Base, exponent)}");
        }
    }
}