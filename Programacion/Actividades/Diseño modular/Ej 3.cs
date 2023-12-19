using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número para retornar el valor absoluto";

            int num, absolute;

            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            absolute = AbsoluteCalculate(num);
            Console.WriteLine($"El valor absoluto de {num} es: {absolute}");
        }

        public static int AbsoluteCalculate(int num)
        {
            int aux;

            if (num > 0)
            {
                aux = num;
            }
            else
            {
                aux = num * -1;
            }
            return aux;
        }
    }
}