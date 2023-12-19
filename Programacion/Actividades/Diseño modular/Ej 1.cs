using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número natural";
            const string SecondEnter = "Introduce el segundo número";

            int Fnum, Snum;

            Console.WriteLine(Start);
            Fnum = NaturalCheck();
            Console.WriteLine(SecondEnter);
            Snum = NaturalCheck();
            Biggest(Fnum, Snum);
        }

        public static int NaturalCheck()
        {
            const string Wrong = "El número no era natural, vuelve a introducir otro número";

            int N;
            bool done = false;

            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine(Wrong);
                }
            } while (!done);

            return N;
        }

        public static void Biggest(int Fnum, int Snum)
        {
            if (Fnum > Snum)
            {
                Console.WriteLine($"El número {Fnum} es más grande que el número {Snum}");
            }
            else if (Fnum == Snum)
            {
                Console.WriteLine($"Los números {Fnum} y {Snum} son iguales");
            }
            else
            {
                Console.WriteLine($"El número {Snum} es más grande que el número {Fnum}");
            }
        }
    }
}