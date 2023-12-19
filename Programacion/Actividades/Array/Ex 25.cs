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
             * Ex 25: Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable textOne. Demana un altre text i emmagatzema’l en la variable textTwo. Afegeix textTwo a textOne i mostra-la per pantalla. És correcte? Què pots observar a les variables textOne i textTwo?
             * M03: Programació
             */

            const string FirstText = "Introduce la primera frase";
            const string SecondText = "Introduce la segunda frase";
            const string ExitProgram = "Pulsa cualquier tecla para salir";

            Console.WriteLine(FirstText);
            string textOne = Console.ReadLine();
            Console.WriteLine(SecondText);
            string textTwo = Console.ReadLine();

            textOne += textTwo;

            Console.WriteLine(textOne);
            Console.WriteLine();  
            Console.WriteLine(ExitProgram);
            Console.ReadKey();
        }
    }
}