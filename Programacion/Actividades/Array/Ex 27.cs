using System;
using System.Text.RegularExpressions;

namespace MyNameSpace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            /*
             * Autor: Tomas Vicente
             * Fecha: 06/11/2023
             * Ex 27: Implementa un programa que demani a l’usuari que introdueixi un text i el retorni tot en majúscules, tot en minúscules i la primera lletra de cada paraula en majúscules (per separat).
             * M03: Programació
             */

            const string NameText = "Introduce el nombre de la persona";
            const string FLastName = "Introduce el primer apellido";
            const string SLastName = "Introduce el segundo apellido";
            const string AgeText = "Introduce la edad de la persona";
            const string ExitProgram = "Pulsa cualquier tecla para salir";

            const int ArrayLimit = 3;

            int age = 0;
            string[] Array = new string[ArrayLimit];
            string Have = "tiene ";
            string Years = " años";
            string HaveMayus = Have.ToUpper();
            string YearsMayus = Years.ToUpper();
            string HaveMinus = Have.ToLower();
            string YearsMinus = Years.ToLower();

            for (int i = 0; i < ArrayLimit; i++)
            {
                Console.WriteLine(NameText);
                Array[i] = Console.ReadLine();
                Console.WriteLine(FLastName);
                Array[i+1] = Console.ReadLine();
                Console.WriteLine(SLastName);
                Array[i+2] = Console.ReadLine();
                Console.WriteLine(AgeText);
                age = Convert.ToInt32(Console.ReadLine());
                i = ArrayLimit - 1;
            }

            for (int i = 0; i < ArrayLimit; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine(Have + age + Years);

            for (int i = 0;i < ArrayLimit; i++)
            {
                string ArrayMayus = Array[i].ToUpper();
                Console.Write(ArrayMayus + " ");
            }
            Console.WriteLine(HaveMayus + age + YearsMayus);

            for (int i = 0; i < ArrayLimit; i++)
            {
                string ArrayMinus = Array[i].ToLower();
                Console.Write(ArrayMinus + " ");
            }
            Console.WriteLine(HaveMinus + age + YearsMinus);

            Console.WriteLine();
            Console.WriteLine(ExitProgram);
            Console.ReadKey();
        }
    }
}