using System;

namespace MyNameSpace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            /*
             * Autor: Tomas Vicente
             * Fecha: 06/11/2023
             * Ex 26: Implementa un programa que demani a l’usuari que introdueixi un text i retorni la seva longitud.
             */

            const string NumText = "Introduce las 20 números";
            const string Even = " es par";
            const string Odd = " es impar";
            const string ExitProgram = "Pulsa cualquier tecla para salir del programa";

            const int NumLimit = 20;

            int[] Num = new int[NumLimit];

            for (int i = 0; i < NumLimit; i++)
            {
                Console.WriteLine(NumText);
                Num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < NumLimit; i++)
            {
                Console.Write(Num[i]);
                Console.WriteLine(Num[i] % 2 == 0 ? Even : Odd);
            }
            Console.WriteLine();
            Console.WriteLine(ExitProgram);
            Console.ReadKey();
        }
    }
}