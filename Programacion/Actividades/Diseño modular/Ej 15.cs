using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string YearInput = "Introduce un año para ver si es biciesto o no";
            const string NotLeap = "El año introducido no es bisiesto";
            const string Leap = "El año si es bisiesto";

            int year;

            Console.WriteLine(YearInput);
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(LeapCalculator(year) == true ? Leap : NotLeap);
        }

        public static bool LeapCalculator(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}