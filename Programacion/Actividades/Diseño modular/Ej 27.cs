using System;

class Program
{
    static void Main()
    {
        const string Input = "Introduce un valor para poder ver para ver si es primo";
        const string Prime = "El numero {0} si es primo";
        const string NoPrime = "El numero {0} no es primo";

        int num, divisor = 2;

        Console.WriteLine(Input);
        num = Convert.ToInt32(Console.ReadLine());
        if (PrimeCalculator(num, divisor))
        {
            Console.WriteLine(Prime, num);
        }
        else
        {
            Console.WriteLine(NoPrime, num);
        }
    }

    public static bool PrimeCalculator(int num, int divisor)
    {
        if (num < divisor)
        {
            return false;
        }
        if (divisor != num)
        {
            if (num % divisor == 0)
            {
                return false;
            }
            return PrimeCalculator(num, divisor + 1);
        }
        return true;
    }
}

