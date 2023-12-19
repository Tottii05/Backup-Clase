using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string NumEnter = "Introduce un valor con decimales para poder mostrar el valor entero y el decimal por separado";

            double num;

            Console.WriteLine(NumEnter);
            num = Convert.ToDouble(Console.ReadLine());
            ValueSaparator(num)
        }

        public static void ValueSaparator(double num)
        {
            const string NaturalValue = "El valor natural de {0} es: {1}";
            const string DecimalValue = "El valor decimal de {0} es: {1}";

            double natural, decimals;

            natural = Math.Truncate(num);
            decimals = num - natural;

            Console.WriteLine(NaturalValue, num, natural);
            Console.WriteLine(DecimalValue, num, Math.Round(decimals,2));
        }
    }
}