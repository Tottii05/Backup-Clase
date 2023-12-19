using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce el número base";
            const string SecondEnter = "Introduce el número exponente";

            float Base, Exponent, final;

            Console.WriteLine(Start);
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SecondEnter);
            Exponent = Convert.ToInt32(Console.ReadLine());
            final = Power(Base, Exponent);
            Console.WriteLine($"La potencia de {Base} elevado a {Exponent} es igual a {final}");
        }

        public static float Power(float Base, float Exponent)
        {
            float total = 1;

            if (Exponent < 0)
            {
                for (float i = Exponent;  i < 0; i++)
                {
                    total /= Base;
                }
            }
            if (Exponent > 0)
            {
                for (int i = 1; i <= Exponent; i++)
                {
                    total *= Base;
                }
            }
            if (Exponent == 0)
            {
                total = 1;
            }

            return total;
        }
    }
}