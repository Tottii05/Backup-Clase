namespace MyNameSpace
{
    class MyClass
    {
        public static void Main()
        {
            const string Input = "Introduce el valor para el valor factorial";

            int num;

            Console.WriteLine(Input);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecSum(num));
        }

        public static int RecSum(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num *= RecSum(num-1);
            }
        }
    }
}