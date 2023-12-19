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
            float[] arrayPluges = { 15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f };

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                for (int j = i+1; j < arrayPluges.Length; j++)
                {
                    if (arrayPluges[i] < arrayPluges[j])
                    {
                        float organize = arrayPluges[i];

                        arrayPluges[i] = arrayPluges[j];
                        arrayPluges[j] = organize;
                    }
                }
            }
            for (int i = 0;i < arrayPluges.Length;i++)
            {
                Console.WriteLine($"Mes {i} {arrayPluges[i]}");
            }
            Console.WriteLine($"La media es: {arrayPluges.Average()}");
        }
    }
}