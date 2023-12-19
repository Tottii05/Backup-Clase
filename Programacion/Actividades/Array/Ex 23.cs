using System;
using System.Security.Cryptography.X509Certificates;

namespace MyNameSpace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            /*
             * Autor: Tomas Vicente
             * Fecha: 06/11/2023
             * Ex 23: Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari si vol mostrar els valors ordenats de manera ascendent o descendent i mostrar-ho per pantalla.
             * M03: Programació
             */

            const string NotesText = "Introduce las 20 notas de los alumnos, deben ser entre [ ";
            const string NoteWrong = "La nota introducida esta fuera del rango de notas permitidas";
            const string FinalText = "Como quieres que sear el orden para mostrar las notas: | 0 - Ascendiente || 1 - Descendiente |";
            const string FinalWrong = "Has elegido un orden no permitido";
            const string ExitProgram = "Pulsa cualquier tecla para salir del programa";

            const int NotesLimit = 2;
            const int NoteMin = 0;
            const int NoteMax = 10;

            int[] Notes = new int[NotesLimit];
            int orderNum;

            for (int i = 0; i < NotesLimit; i++)
            {
                Console.WriteLine(NotesText + NoteMin + " - " + NoteMax + " ]");
                Notes[i] = Convert.ToInt32(Console.ReadLine());
                if (Notes[i] < NoteMin || Notes[i] > NoteMax)
                {
                    Console.WriteLine(NoteWrong);
                    i--;
                }
            }
            Console.WriteLine(FinalText);
            orderNum = Convert.ToInt32(Console.ReadLine());
            while (orderNum < 0 || orderNum > 1)
            {
                Console.WriteLine(FinalWrong);
                Console.WriteLine(FinalText);
                orderNum = Convert.ToInt32(Console.ReadLine());
            }
            if (orderNum == 0)
            {
                for (int i = NotesLimit - 1; i >= 0; i--)
                {
                    Console.Write(Notes[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(ExitProgram);
                Console.ReadKey();
            }
            if (orderNum == 1)
            {
                for (int i = 0; i < NotesLimit; i++)
                {
                    Console.Write(Notes[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(ExitProgram);
                Console.ReadKey();
            }
        }
    }
}