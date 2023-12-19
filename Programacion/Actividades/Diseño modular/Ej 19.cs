using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string Input = "Introduce un número";

            int firstNum, secondNum;
            Console.WriteLine(Input);
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Input);
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De los números {firstNum} y {secondNum} el mínimo es {MinCalculator(firstNum, secondNum)} y el máximo es {MaxCalculator(firstNum, secondNum)}");
        }

        public static int MinCalculator(int firstNum, int secondNum)
        {
            return Math.Min(firstNum, secondNum);
        }
        public static int MaxCalculator(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }
    }
}