using System;

namespace entero {
    class inicio {
        static void Main(string[] args) {
            int TotalNum = 100;
            int even = 0;
            int inicio = 0;
            for (int i = inicio;  i <= TotalNum; i++)
            {
                if (!(inicio % 2 == 0))
                {
                    even++;
                    inicio++;
                    Console.WriteLine(even);
                }
                else
                {
                    inicio++;
                    even++;
                }
            }
        }
    }
}