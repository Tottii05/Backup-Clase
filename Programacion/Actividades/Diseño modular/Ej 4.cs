using System;

namespace Testing
{
    public class Validate
    {
        public static void Main()
        {
            const string Start = "Introduce un texto";
            const string Change = "Como lo quieres devolver: 0 - Mayúsculas | 1 - Minúsculas";
            const string WrongInput = "Introduciste un valor fuera de rango, vuelve a ponerlo:";

            int choice;

            Console.WriteLine(Start);
            string phrase = Console.ReadLine();
            Console.WriteLine(Change);
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice > 1)
            {
                Console.WriteLine(WrongInput);
                choice = Convert.ToInt32(Console.ReadLine());
            }
            string final = StringChange(phrase, choice);
            Console.WriteLine(final);
        }

        public static string StringChange(string phrase, int choice)
        {
            string aux;

            if (choice == 0)
            {
                aux = phrase.ToUpper();
            }
            else
            {
                aux = phrase.ToLower();
            }
            return aux;
        }
    }
}