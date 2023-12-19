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
             * Ex 24: Fent servir la interpolació, implementa un programa en el que es demani a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu.
             * M03: Programació
             */

            const string NameText = "Introduce el nombre de la persona";
            const string FLastNameText = "Instroduce el primer apellido de la persona";
            const string SLastNameText = "Introduce el segundo apellido de la persona";
            const string AgeInsertText = "Introduce la edad de la persona";
            const string ExitProgram = "Pulsa cualquier tecla para salir del programa";

            const int PhraseLimit = 3;
            const int AgeLimit = 1;

            Console.WriteLine(NameText);
            string name = Console.ReadLine();
            Console.WriteLine(FLastNameText);
            string FLastName = Console.ReadLine();
            Console.WriteLine(SLastNameText);
            string SLastName = Console.ReadLine();
            Console.WriteLine(AgeInsertText);
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"{name} {FLastName} {SLastName} tiene {age} años");
            Console.WriteLine();
            Console.WriteLine(ExitProgram);
            Console.ReadKey();
        }
    }
}