using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string MinuteInput = "Introduce el tiempo en minutos para ver el equivalente en segundos";

            int min;

            Console.WriteLine(MinuteInput);
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{min} minutos equivalen a {MinSecTranformer(min)} segundos");
        }

        public static int MinSecTranformer(int min)
        {
            const int SecTransformer = 60;
            return min * SecTransformer;
        }
    }
}