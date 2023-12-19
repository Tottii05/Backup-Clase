using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número para ver cuantos dígitos tiene";

            int num, digits, evenDigitsSum = 0, oddDigitsSum = 0;
            
            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            digits = DigitCounter(num);
            Console.WriteLine($"El número {num} tiene {digits} dígitos");
            Console.WriteLine($"La suma de los digitos pares del número {num} es: {EvenDigitSum(num, evenDigitsSum)}");
            Console.WriteLine($"La suma de los digitos impares del número {num} es: {OddDigitSum(num, oddDigitsSum)}");
        }

        public static int DigitCounter(int num)
        {
            int aux = num, digitsCount = 1;
            bool done = false;
            
            do
            {
                if (aux >= 10)
                {
                    aux /= 10;
                    digitsCount++;
                }
                else
                {
                    done = true;
                }
            }while(!done);

            return digitsCount; 
        }

        public static int EvenDigitSum(int num, int evenDigitsSum)
        {
            do
            {
                if (num % 10 % 2 == 0)
                {
                    evenDigitsSum += num % 10;
                }
                num /= 10;
            } while (num > 0);

            return evenDigitsSum;
        }

        public static int OddDigitSum(int num, int oddDigitsSum)
        {
            do
            {
                if (num % 10 % 2 != 0)
                {
                    oddDigitsSum += num % 10;
                }
                num /= 10;
            } while (num > 0);

            return oddDigitsSum;
        }
    }
}