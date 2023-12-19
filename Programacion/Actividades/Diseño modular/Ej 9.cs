using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número para ver si es más pequeño que un valor, o si está dentro de un rango de valores";
            const string CheckInput = "Introduce un número a comparar con el primero";
            const string MinText = "Introduce el valor mínimo del rango de valores";
            const string MaxText = "Introduce el valor máximo del rango de valores";
            const string Smaller = "El primer número es más pequeño que el segundo";
            const string NotSmaller = "El primer número no es más pequeño que el segundo";
            const string Between = "El número está dentro del valor de rangos";
            const string NotBetween = "El número no está dentro del valor de rangos";

            int num, checkNum, max, min;
            bool final;

            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckInput);
            checkNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MinText);
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MaxText);
            max = Convert.ToInt32(Console.ReadLine());
            final = Check(num, checkNum);
            Console.WriteLine(final == true ? Smaller : NotSmaller);
            final = Check(num, min, max);
            Console.WriteLine(final == true ? Between : NotBetween);
        }

        public static bool Check(int num, int checkNum)
        {
            return num < checkNum;
        }

        public static bool Check(int num, int min, int max)
        {
            return num > min && num < max;
        }
    }
}