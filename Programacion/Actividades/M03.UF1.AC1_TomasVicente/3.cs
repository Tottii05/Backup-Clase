 using System;

namespace entero {
  class inicio {
    static void Main(string[] args){
        const string NumEnter = "Introduce un número: ";
        const string Mal =  "El número introducido no era un número entero, prueba otra vez: ";
        const string Even = "Los números pares són: ";
        const string Odd = "Los números impares són: ";
        const int TotalNum = 0;
        float num;
        int odd = 0, even = 0;
        string final;
        for (int i = TotalNum; i < 20; i++){
            Console.WriteLine(NumEnter);
            num = Convert.ToSingle(Console.ReadLine());
            if (num % 1 != 0){
                Console.WriteLine(Mal);
                Console.WriteLine(NumEnter);
                num = Convert.ToSingle(Console.ReadLine());
            }
            else {
                final = (num % 2 == 0) ? Even + even++ : Odd +odd++;
            }
        }
        Console.WriteLine(Even + even);
        Console.WriteLine(Odd + odd);
    }
  }
}