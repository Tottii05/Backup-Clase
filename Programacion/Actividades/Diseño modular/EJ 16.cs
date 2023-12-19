using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string QuantityInput = "Indica cuantos valores quieres introducir:";
            const string InputText = "Introduce un valor entre [15 y 100]. Tienes {0} intentos";
            const string WrongInput = "El valor introducido no es válido.";
            const string OutOfTrys = "Te has quedado sin intentos";

            const int MinInput = 15, MaxInput = 100;

            int MaxNumbers, input, trys = 5, productNum = 1;
            Console.WriteLine(QuantityInput);
            MaxNumbers = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[MaxNumbers];
            int i = 0;
            do
            {
                Console.WriteLine(InputText, trys);
                input = Convert.ToInt32(Console.ReadLine());
                if (input < MinInput || input > MaxInput)
                {
                    Console.WriteLine(WrongInput);
                    trys--;
                }
                else
                {
                    numbers[i] = input;
                    i++;
                }
            } while (trys > 0 && i < numbers.Length);

            Console.WriteLine(trys == 0 ? OutOfTrys : FinalProduct(numbers, productNum));
        }

        public static int FinalProduct(int[] numbers, int productNum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                productNum = productNum * numbers[i];
            }
            return productNum;
        }
    }
}