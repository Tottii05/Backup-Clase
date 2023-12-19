using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string NumEnter = "Introduce un valor en números romanos para ver su valor entero.";

            string RomanNumbers;

            Console.WriteLine(NumEnter);
            RomanNumbers = Console.ReadLine().ToUpper();
            RomanNumTransformator(RomanNumbers);
        }

        public static void RomanNumTransformator(string RomanNumbers)
        {
            const int RomanI = 1, RomanV = 5, RomanX = 10, RomanL = 50, RomanC = 100, RomanD = 500, RomanM = 1000;

            int value = 0;

            foreach (char c in RomanNumbers)
            {
                switch (c)
                {
                    case 'I':
                        value += RomanI;
                        break;
                    case 'V':
                        value += RomanV;
                        break;
                    case 'X':
                        value += RomanX;
                        break;
                    case 'L':
                        value += RomanL;
                        break;
                    case 'C':
                        value += RomanC;
                        break;
                    case 'D':
                        value += RomanD;
                        break;
                    case 'M':
                        value += RomanM;
                        break;
                    default:
                        Console.WriteLine($"{c} No es un numero romano"); 
                        break;
                }
            }
            Console.WriteLine(value);
        }
    }
}