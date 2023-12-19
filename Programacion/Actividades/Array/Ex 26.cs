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
             * Ex 26: Implementa un programa que demani a l’usuari que introdueixi un text i retorni la seva longitud.
             * M03: Programació
             */

            const string InputText = "Introduce una palabra";
            const string LengthText = "La palabra tiene esta cantidad de letras: ";
            const string ExitProgram = "Pulsa cualquier tecla para salir";

            Console.WriteLine(InputText);
            string word = Console.ReadLine();
            int letters = word.Length;
            Console.WriteLine(LengthText + letters);
            Console.WriteLine();  
            Console.WriteLine(ExitProgram);
            Console.ReadKey();
        }
    }
}