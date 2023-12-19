using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número para devolver su valor factorial";

            int num, factorial;

            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            factorial = FactorialConvert(num);
            Console.WriteLine($"El valor factorial de {num} es: {factorial}");
        }

        public static int FactorialConvert(int num)
        {
            int aux = 1;

            for (int i = 1; i <= num; i++)
            {
                aux *= i;
            }

            return aux;
        }
    }
}