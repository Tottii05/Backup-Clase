using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Se han generado 10 números aleatorios entre 0 y 200, intenta adivinar uno";
            const string Win = "Has acertado! Será suerte o hiciste trampa? Quien sabe...";
            const string Lose = "Ese número no era, una pena, en verdad no, no es una pena";

            const int randMin = 0, randMax = 201;
            const int min = 0, max = 10;

            int[] randArray = new int[max];
            int num;

            for (int i = min; i < randArray.Length; i++)
            {
                Random random = new Random();
                randArray[i] = random.Next(randMin, randMax);
            }

            Console.WriteLine(Start);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RandomCheck(num, randArray) == true ? Win:Lose);
        }

        public static bool RandomCheck(int num, int[] randArray)
        {
            int i = 0;
            bool founded = false;
            do
            {
                if (num == randArray[i])
                {
                    founded = true; 
                }
                else
                {
                    i++;
                }
            } while (i < randArray.Length && !founded);
            return founded;
        }
    }
}