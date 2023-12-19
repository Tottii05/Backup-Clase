using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número para saber si es natural y menor que 100";

            int num;
            bool final;

            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            final = NaturalAboveCheck(num);
            Console.WriteLine(final);
        }

        public static bool NaturalAboveCheck(int num)
        {
            bool aux;
            aux = num > 0 && num < 100 ? aux = true : aux = false;
            
            return aux;
        }
    }
}