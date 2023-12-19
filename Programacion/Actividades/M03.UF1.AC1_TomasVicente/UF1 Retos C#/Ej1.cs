/*
 * Autor: Tomas Vicente
 * M03 Programación en C# UF1
 * V2 16/10/2023
 * Ejercicio 1
 */

using System;
namespace entero
{
    class inicio
    {
        static void Main(string[] args)
        {
            const int RammusAttack = 20, TwitchAttack = 25;
            int RedHealth = 1000, Rondas = 0;

            while (RedHealth > 0)
            { 
                RedHealth -= RammusAttack;
                Rondas++;
                if (RedHealth <= 0)
                {
                    Console.WriteLine("RAMMUS" + " " + Rondas);
                }
                else
                {
                    RedHealth -= TwitchAttack;
                    if (RedHealth <= 0)
                    {
                        Console.WriteLine("TWITCH" + " " + Rondas);
                    }
                }
            }
        }
    }
}
