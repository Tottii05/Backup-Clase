using System;

namespace entero
{
    class inicio
    {
        static void Main(string[] args)
        {
            const string Weight = "Introduce el peso del producto (libras): ";
            const string ReturnWright = "El peso del producto en Kg es: ";
            const string Menu = "|Para introducir otro peso de producto pulse 1 | Para salir pulse 0 |";
            const float Conversor = 2.20f;
            float pound, kg;
            int answer;
            Console.WriteLine(Weight);
            pound = Convert.ToSingle(Console.ReadLine());
            kg = (pound / Conversor);
            Console.WriteLine(ReturnWright + kg + "Kg");
            Console.WriteLine(Menu);
            answer = Convert.ToInt16(Console.ReadLine());
            while (!(answer == 0)) {
                Console.WriteLine(Weight);
                pound = Convert.ToSingle(Console.ReadLine());
                kg = (pound / Conversor);
                Console.WriteLine(ReturnWright + kg + "Kg");
                Console.WriteLine(Menu);
                answer = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Hasta la próxima :D");
        }
    }
}