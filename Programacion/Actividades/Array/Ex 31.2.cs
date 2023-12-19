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
            const string Search = "Introduce que número para buscar en la lista";
            const string Founded = "El número si está en la lista";
            const string NotFounded = "El número no está en la lista";

            float[] arrayPluges = { 15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f };
            int Averages = 0, position = 0;
            float searchedNum;
            bool Found = false;

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

            foreach (float lluvias in arrayPluges)
            {
                if (lluvias >= 5 && lluvias <= 18)
                {
                    Averages++;
                }
            }

            for (int i = 0;i < arrayPluges.Length;i++)
            {
                Console.WriteLine($"Mes {i}: {arrayPluges[i]}");
            }
            Console.WriteLine($"La media es: {arrayPluges.Average()}");
            Console.WriteLine($"Hay {Averages} meses con una media de lluvias entre 5 y 18");

            Console.WriteLine(Search);
            searchedNum = Convert.ToSingle(Console.ReadLine());

            while (position < arrayPluges.Length && !Found)
            {
                if (searchedNum == arrayPluges[position])
                {
                    Found = true;
                }
                position++;
            }
            Console.WriteLine(Found ? Founded : NotFounded);
        }
    }
}