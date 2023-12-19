using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un número";
            const string Final = "Las posiciones impares de la array tienen estos valores";

            const int MaxLrngth = 20;

            int[] array = new int[MaxLrngth];
            int num;

            for (int i = 0; i < MaxLrngth; i++)
            {
                Console.WriteLine(Start);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] final = OddArrayPosition(array);
            Console.WriteLine(Final);

            for (int i = 0; i < final.Length; i++)
            {
                Console.Write(final[i] + " ");
            }
        }

        public static int[] OddArrayPosition(int[] array)
        {
            int[] oddArray = new int[array.Length / 2];
            
            for (int i = 0; i < oddArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddArray[i] = array[i];
                }
            }

            return oddArray; 
        }
    }
}