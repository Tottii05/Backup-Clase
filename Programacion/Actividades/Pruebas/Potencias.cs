namespace MyNameSpace
{
    class MyClass
    {
        public static void Main()
        {
            const string Input = "Introduce la base y el exponente para ver la poténcia";

            int baseNum, powerNum;

            Console.WriteLine(Input);
            baseNum = Convert.ToInt32(Console.ReadLine());
            powerNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecSum(baseNum, powerNum));
        }

        public static int RecSum(int baseNum, int powerNum)
        {
            if (powerNum == 0)
            {
                return 1;
            }
            else
            {
                return baseNum *= RecSum(baseNum,powerNum-1);
            }
        }
    }
}