using System;

namespace MyNamespace
{
    public class MyClass
    {
        static void Main()
        {
            const string StartChoice = "Vamos a calcular un área, de que figura la quieres cualcular: | 1- Cuadrado | 2- Rectángulo | 3- Círculo | 4- Pentágono |";
            const string WrongInput = "Has elegido un valor no permitido";
            const string SquareInput = "Has elegido el cuadrado!, introduce la longitud de uno de los lados";
            const string RectangleInput = "Has elegido el rectángulo!, introduce el ancho y el largo";
            const string CircleInput = "Has elegido el círculo!, introduce el radio";
            const string PenthagonInput = "Has elegido el pentagono!, introduce el largo de un lado y la apotema";
            const string ShowArea = "El área del {0} es {1}";

            double height = 0, large = 0, width = 0, radius = 0, pi = Math.PI, side = 0;
            float apothem = 0f;
            int choice, elevated = 2;

            Console.WriteLine(StartChoice);
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(SquareInput);
                    height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(ShowArea, "cuadrado", AreaCalculator(height));
                    break;
                case 2:
                    Console.WriteLine(RectangleInput);
                    large = Convert.ToDouble(Console.ReadLine());
                    width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(ShowArea, "rectángulo", AreaCalculator(large, width));
                    break;
                case 3:
                    Console.WriteLine(CircleInput);
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(ShowArea, "círculo", AreaCalculator(radius, pi, elevated));
                    break;
                case 4:
                    Console.WriteLine(PenthagonInput);
                    side = Convert.ToDouble(Console.ReadLine());
                    apothem = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(ShowArea, "pentágono", AreaCalculator(side, apothem));
                    break;
                default:
                    Console.WriteLine(WrongInput);
                    break;
            }
        }
        public static double AreaCalculator(double height)
        {
            return height *= height; 
        }
        public static double AreaCalculator(double large, double width)
        {
            return large * width;
        }
        public static double AreaCalculator(double radius, double pi, double elevated)
        {
            return Math.Round(Math.PI * Math.Pow(radius, elevated), 2);
        }
        public static double AreaCalculator(double side, float apothem)
        {
            return side * 5 * apothem / 2;
        }
    }
}