using System;

namespace entero
{
    class inicio
    {
        static void Main(string[] args)
        {
            const string NumEnter = "Introduce un la nota del alumno: ";
            const string Mal = "La nota introducida no era un número natural, prueba otra vez: ";
            const string Aprobados = "La cantidad de aprobados és: ";
            const string Suspendidos = "La cantidad de suspendidos és: ";
            const string AprobadosMedia = "La media de aprobados és: ";
            const string SuspendidosMedia = "La media de suspendidos és: ";
            const int TotalNum = 0;
            float num;
            float passed = 0, failed = 0;
            float totalPass = 0, totalFail = 0;
            for (int i = TotalNum; i < 8; i++)
            {
                Console.WriteLine(NumEnter);
                num = Convert.ToSingle(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine(Mal);
                    Console.WriteLine(NumEnter);
                    num = Convert.ToSingle(Console.ReadLine());
                }
                else if (num >= 5)
                {
                    totalPass++;
                    passed += num;
                } 
                else
                {
                    totalFail++;
                    failed += num;
                }    
                        
            }
            Console.WriteLine(Aprobados + totalPass);
            Console.WriteLine(Suspendidos + totalFail);
            Console.WriteLine(AprobadosMedia + ( passed / totalPass));
            Console.WriteLine(SuspendidosMedia + ( failed / totalFail));
        }
    }
}