using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce la cantidad de litros consumidos este mes";

            const int Fee = 6;

            int liter;
            double final;
            Console.WriteLine(Start);
            liter = Convert.ToInt32(Console.ReadLine());
            final = WatterPrice(liter,Fee);
            Console.WriteLine($"El precio de la agua es: {final}");
        }

        public static double WatterPrice(int liter, int Fee)
        {
            double aux = Fee, extraBetween = 0.1, extraBigger = 0.3;

            for (int i = liter; i > 50; i--)
            {
                if (liter < 200)
                {
                    aux += extraBetween;
                }
                else
                {
                    aux += extraBigger;
                }
            }

            return Math.Round(aux,1); 
        }
    }
}