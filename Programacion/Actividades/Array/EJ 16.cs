/*
 * Autor: Tomas Vicente
 * Fecha: 25/10/2023
 * EJ 15: Implementa un programa que demani  a l’usuari 10 enters per teclat i els mostri en sentit contrari al que s’ha introduït.
 */

using System;

namespace Programita
{
    class MyClass
    {
        static void Main(string[] args)
        {
            const string NumText = "Introduce un número:";

            int Size = 3;

            int[] Array = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(NumText);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = Size-1; i >= 0; i--)
            {
                Console.Write(Array[i] + " ");
            }
        }
    }
}

