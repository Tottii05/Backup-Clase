using System;
using System.Runtime.CompilerServices;

namespace Refactoring
{
    class FirstRefactoringExercise
    {
        static void Main()
        {
            const string QuantityInput = "Indica quants valors vols introduir:";
            const string InputText = "introdueix un valor entre el 5 i el 150 (inclosos). Tens {0} intents com a màxim";
            const string WrongInput = "El valor introduït no és vàlid.";
            const string OutOfTrys = "Has superat el total d'intents.";

            const int MinInput = 5, MaxInput = 150;

            int quantity, input, trys = 3, answer = 1;
            Console.WriteLine(QuantityInput);
            quantity = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[quantity];
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

            Console.WriteLine(trys == 0 ? OutOfTrys : FinalProduct(numbers,answer));
        }

        public static int FinalProduct(int[] numbers, int answer)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                answer = answer * numbers[i];
            }
            return answer;
        }
    }
}