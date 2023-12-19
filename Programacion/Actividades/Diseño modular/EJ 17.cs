using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string DegreeInput = "Introduce los grados en Celcius para ver el equivalente en Fahrenheit";

            double degreesC;

            Console.WriteLine(DegreeInput);
            degreesC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{degreesC} grados Celcius equivalen a {FahrenheitCalculator(degreesC)} grados Fahrenheit");
        }

        public static double FahrenheitCalculator(double degreesC)
        {
            const int Mult = 9, Div = 5, Sum = 32;
            double fahrenheit = degreesC * Mult / Div + Sum;
            return Math.Round(fahrenheit, 2);
        }
    }
}