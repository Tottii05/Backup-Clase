namespace Characters
{
    public class Create
    {
        public const string WrongNum = "Has puesto un valor fuera del rango, ";
        public const string TryAgain = "prueba otra vez:";
        public const string StatConfirmation = "La stat ha sido creada ";
        const string Correctly = "CORRECTAMENTE";
        public const string triesIndicator = "Te quedan estos intentos para crear la stat: ";
        public static float HP(ref int tries, ref float valueHP, int MaxHP, int MinHP)
        {
            if ((valueHP >= MinHP) && (valueHP <= MaxHP))
            {
                Console.ResetColor();
                Console.Write(StatConfirmation);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Correctly);
                Console.ResetColor();
                Console.WriteLine();
                return valueHP;
            }
            else
            {
                Console.Write(WrongNum);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(TryAgain);
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine();
                tries--;
                Console.Write(triesIndicator);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(tries);
                Console.ResetColor();
                return valueHP = 0;
            }
        }
        public static int MinHP(int MinHP)
        {
            return MinHP;
        }
        public static int MaxHP(int MaxHP)
        {
            return MaxHP;
        }
        public static int RandHP(int MinHP, int MaxHP)
        {
            Random random = new Random();
            return random.Next(MinHP, MaxHP + 1);
        }
    }
}