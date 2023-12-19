using System;

namespace entero {
  class inicio {
    static void Main(string[] args){
        const string NumEnter = "Introduce un número entero para calcular el valor absoluto: ";
        const string Mal =  "El número introducido no era un número entero, prueba otra vez: ";
        const string Text = "El valor absoluto es: ";
        float num;
        string final;
        Console.WriteLine(NumEnter);
        num = Convert.ToSingle(Console.ReadLine());
        while (!(num % 1 == 0)){
            Console.WriteLine(Mal);
            Console.WriteLine(NumEnter);
            num = Convert.ToSingle(Console.ReadLine());            
            }
        final = num > 0 ? Text + num : Text + (num * -1);
        Console.WriteLine(final);
    }
  }
}