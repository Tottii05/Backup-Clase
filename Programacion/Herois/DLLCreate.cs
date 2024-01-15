namespace Characters
{
    public class Create
    {
        public static bool ArcherHp(int tries, bool StatCreated, int globalTries, float ArcherHP)
        {
            const string WrongNum = "Has puesto un valor fuera del rango, ";
            const string TryAgain = "prueba otra vez:";
            const string StatConfirmation = "La stat ha sido creada ";
            const string Correctly = "CORRECTAMENTE";
            const string triesIndicator = "Te quedan estos intentos para crear la stat: ";

            const int ArcherHpMin = 1500, ArcherHpMax = 2000;


            if ((ArcherHP >= ArcherHpMin) && (ArcherHP <= ArcherHpMax))
            {
                Console.ResetColor();
                Console.Write(StatConfirmation);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Correctly);
                Console.ResetColor();
                Console.WriteLine();

                return StatCreated = true;
            }
            else
            {
                Console.Write(WrongNum);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(TryAgain);
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine();
                tries = ReturnTries(tries);
                Console.Write(triesIndicator);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(tries);
                Console.ResetColor();


                return StatCreated = false;
            }
        }
        public static bool ArcherAtk(int tries, bool StatCreated, int globalTries, float ArcherAtk)
        {
            const string WrongNum = "Has puesto un valor fuera del rango, ";
            const string TryAgain = "prueba otra vez:";
            const string StatConfirmation = "La stat ha sido creada ";
            const string Correctly = "CORRECTAMENTE";
            const string triesIndicator = "Te quedan estos intentos para crear la stat: ";

            const int ArcherAtkMin = 180, ArcherAtkMax = 300;


            if ((ArcherAtk >= ArcherAtkMin) && (ArcherAtk <= ArcherAtkMax))
            {
                Console.ResetColor();
                Console.Write(StatConfirmation);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Correctly);
                Console.ResetColor();
                Console.WriteLine();

                return StatCreated = true;
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

                return StatCreated = false;
            }
        }

        public static bool ArcherDef(int tries, bool StatCreated, int globalTries, float ArcherDef)
        {
            const string DefStat = "Introduce el valor de la defensa";
            const string WrongNum = "Has puesto un valor fuera del rango, ";
            const string TryAgain = "prueba otra vez:";
            const string StatConfirmation = "La stat ha sido creada ";
            const string Correctly = "CORRECTAMENTE";
            const string triesIndicator = "Te quedan estos intentos para crear la stat: ";

            const int ArcherDefMin = 25, ArcherDefMax = 40;

            tries = 3;

            Console.WriteLine(DefStat + "[" + ArcherDefMin + "-" + ArcherDefMax + "]");
            if ((ArcherDef >= ArcherDefMin) && (ArcherDef <= ArcherDefMax))
            {
                Console.ResetColor();
                Console.Write(StatConfirmation);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Correctly);
                Console.ResetColor();
                Console.WriteLine();

                return StatCreated = true;
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

                return StatCreated = false;
            }
        }
        public static int ReturnTries(int tries)
        {
            return tries - 1;
        }
















































































        public static int NoTriesLeft(int globalTries)
        {
            const string StatsFail = "Has fallado 3 veces creando la stat y se te ha restado 1 a tus intentos para crear el personaje, te quedan: ";

            Console.WriteLine(StatsFail + globalTries);
            Console.WriteLine();
            return --globalTries;
        }
    }
}


