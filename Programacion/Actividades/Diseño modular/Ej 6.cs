using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número para mostrar el valor absoluto";

            int num, final;

            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            final = AbsoluteNumber(num);
            Console.WriteLine($"El valor absoluto de {num} es: {final}");
        }

        public static int AbsoluteNumber(int num)
        {
            int aux;
            return aux = Math.Abs(num);
        }
    }
}