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
            const string CharacterCreation = "Estas creando al personaje: ";
            const string characterFinalText = "Personaje: ";
            const string WrongNum = "Has puesto un valor fuera del rango, prueba otra vez:";
            const string HpText = "Introduce la vida: ";
            const string PwText = "Introduce el poder: ";
            const string SthText = "Introduce la fuerza: ";
            const string Hp = "vida";
            const string Pw = "ataque";
            const string Sth = "fuerza";
            const string Horizontal = "-------------------------";
            const string Vertical = "|";

            const int HpMin = 1;
            const int HpMax = 1000;
            const int PwMin = 100;
            const int PwMax = 500;
            const int SthMin = 20;
            const int SthMax = 50;

            int character = 1, characterSize = 4, statSize = 3;

            int[,] Array = new int[characterSize, statSize];


            for (int i = 0; i < characterSize; i++)
            {
                Console.WriteLine(CharacterCreation + character);
                character++;
                Console.WriteLine();
                for (int j = 0; j < statSize; j++)
                {
                    Console.WriteLine(HpText + "[ " + HpMin + " - " + HpMax + " ]");
                    Array[i,j] = Convert.ToInt32(Console.ReadLine());
                    while (Array[i,j] < HpMin || Array[i,j] > HpMax)
                    {
                        Console.WriteLine(WrongNum);
                        Console.WriteLine(HpText + "[ " + HpMin + " - " + HpMax + " ]");
                        Array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine(PwText + "[ " + PwMin + " - " + PwMax + " ]");
                    Array[i, j+1] = Convert.ToInt32(Console.ReadLine());
                    while (Array[i, j+1] < PwMin || Array[i, j + 1] > PwMax)
                    {
                        Console.WriteLine(WrongNum);
                        Console.WriteLine(PwText + "[ " + PwMin + " - " + PwMax + " ]");
                        Array[i, j+1] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine(SthText + "[ " + SthMin + " - " + SthMax + " ]");
                    Array[i, j + 2] = Convert.ToInt32(Console.ReadLine());
                    while (Array[i, j + 2] < SthMin || Array[i, j + 2 ] > SthMax)
                    {
                        Console.WriteLine(WrongNum);
                        Console.WriteLine(SthText + "[ " + SthMin + " - " + SthMax + " ]");
                        Array[i, j + 2] = Convert.ToInt32(Console.ReadLine());
                    }
                    j = statSize - 1;
                }
            }
            character = 1;
            for (int i = 0; i < characterSize; i++)
            {
                Console.WriteLine(characterFinalText + character);
                character++;
                for (int j = 0; j < statSize; j++)
                {
                    Console.WriteLine(Horizontal);
                    Console.WriteLine(Vertical + Hp + "\t" + Vertical + Pw + "\t" + Vertical  + Sth + "\t" + Vertical);
                    Console.WriteLine(Horizontal);
                    Console.WriteLine(Vertical + Array[i,j] + "\t" + Vertical + Array[i,j+1] + "\t" + Vertical + Array[i,j+2] + "\t"+ Vertical);
                    Console.WriteLine(Horizontal);
                    Console.WriteLine();
                    j = statSize - 1;
                }
            }
        }
    }
}