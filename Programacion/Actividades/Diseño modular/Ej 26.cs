using System;

class Program
{
    static void Main()
    {
        const string Input = "Introduce un valor para poder ver cuantos digitos tiene";

        int num, digits = 1;

        Console.WriteLine(Input);   
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(DigitCalcualtor(num, digits));
    }

    public static int DigitCalcualtor(int num, int digits)
    {
        if (num <10)
        {
            return digits;
        }
        else
        {
            num /=10;
            return digits += DigitCalcualtor(num, digits);
        }
    }
}
