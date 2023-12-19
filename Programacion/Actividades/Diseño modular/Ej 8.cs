using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const int Min = 0, Max = 257, MaxNum = 9;

            Random rand = new Random();
            

            for (int i = Min; i <= MaxNum; i++)
            {
                int num = rand.Next(Min, Max);
                Console.WriteLine(num);
            }
        }
    }
}