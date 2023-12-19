using System;
using System.Runtime.Serialization.Formatters;

namespace MyNameSpace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            /*
             * Autor: Tomas Vicente
             * Fecha: 06/11/2023
             * Ex 29: Fent servir la interpolació, implementa un programa en el que es demani a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu.
             * M03: Programació
             */
            const string ExitProgram = "Pulsa cualquier tecla para salir del programa";

            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[] { 1, 2, 3, 4 };
            jaggedArr[1] = new int[] { 11, 34, 67 };
            jaggedArr[2] = new int[] { 89, 23 };
            jaggedArr[3] = new int[] { 0, 45, 78, 53, 99 };

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                int content = 0;
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    content += jaggedArr[i][j];
                    if (j < jaggedArr[i].Length - 1)
                    {
                    }
                }
                Console.WriteLine($"Fila: 0 {content}");
            }
            Console.WriteLine();
            Console.WriteLine(ExitProgram);
            Console.ReadKey();
        }
    }
}