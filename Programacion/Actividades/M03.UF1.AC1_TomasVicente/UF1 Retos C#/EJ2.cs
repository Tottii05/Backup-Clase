/*
 * Autor: Tomas Vicente
 * M03 Programación en C# UF1
 * V1 16/10/2023
 * Ejercicio 2
 */

using System;
using System.Globalization;

namespace entero
{
    class inicio
    {
        static void Main(string[] args)
        {
            const string FloorsText= "Introduce el número de plantas:";
            const string TryText = "Introduce el número de intentos";
            int Ferrero = 1, Floors, Try;

            Console.WriteLine(TryText);
            Try = Convert.ToInt32(Console.ReadLine());

            for (int i = Try; i > 0; i--)
            { 
                Console.WriteLine(FloorsText);
                Floors = Convert.ToInt32(Console.ReadLine());

                Ferrero = (Floors * (Floors + 1) * ((2 * Floors) + 1)) / 6;
                Console.WriteLine(Ferrero);
            }
        }
    }
}