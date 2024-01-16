namespace Characters
{
    public class Create
    {
        public static void ArcherHp(ref int tries, ref bool StatCreated, float ArcherHP)
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
                StatCreated = true;
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
                StatCreated = false;
            }
        }
        public static float ArcherMinHp(ref float ArcherHP)
        {
            const int ArcherHpMin = 1500;
            return ArcherHP = ArcherHpMin;
        }
        public static float ArcherMaxHp(ref float ArcherHP)
        {
            const int ArcherHpMax = 2000;
            return ArcherHP = ArcherHpMax;
        }
        public static float ArcherRandHp(ref float ArcherHP)
        {
            const int ArcherHpMin = 1500, ArcherHpMax = 2000;
            Random random = new Random();
            return ArcherHP = random.Next(ArcherHpMin, ArcherHpMax + 1);
        }
        public static void ArcherAtk(ref int tries, ref bool StatCreated, float ArcherAtk)
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
                StatCreated = true;
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
                StatCreated = false;
            }
        }
        public static float ArcherMinAtk(ref float ArcherAtk)
        {
            const int ArcherAtkMin = 180;
            return ArcherAtk = ArcherAtkMin;
        }
        public static float ArcherMaxAtk(ref float ArcherAtk)
        {
            const int ArcherAtkMax = 300;
            return ArcherAtk = ArcherAtkMax;
        }
        public static float ArcherRandAtk(ref float ArcherAtk)
        {
            const int ArcherAtkMin = 180, ArcherAtkMax = 300;
            Random random = new Random();
            return ArcherAtk = random.Next(ArcherAtkMin, ArcherAtkMax + 1);
        }
        public static void ArcherDef(ref int tries, ref bool StatCreated, float ArcherDef, ref bool CharacterCreated)
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
                StatCreated = true;
                CharacterCreated = true;
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
                StatCreated = false;
            }
        }
        public static float ArcherMinDef(ref float ArcherDef)
        {
            const int ArcherDefMin = 25;
            return ArcherDef = ArcherDefMin;
        }
        public static float ArcherMaxDef(ref float ArcherDef)
        {
            const int ArcherDefMax = 40;
            return ArcherDef = ArcherDefMax;
        }
        public static float ArcherRandDef(ref float ArcherDef)
        {
            const int ArcherDefMin = 25, ArcherDefMax = 40;
            Random random = new Random();
            return ArcherDef = random.Next(ArcherDefMin, ArcherDefMax + 1);
        }
        public static void MinArcherStats(ref float ArcherHP, ref float ArcherAtk, ref float ArcherDef)
        {
            ArcherHP = ArcherMinHp(ref ArcherHP);
            ArcherAtk = ArcherMinAtk(ref ArcherAtk);
            ArcherDef = ArcherMinDef(ref ArcherDef);
        }
        public static void MaxArcherStats(ref float ArcherHP, ref float ArcherAtk, ref float ArcherDef)
        {
            ArcherHP = ArcherMaxHp(ref ArcherHP);
            ArcherAtk = ArcherMaxAtk(ref ArcherAtk);
            ArcherDef = ArcherMaxDef(ref ArcherDef);
        }
        public static void RandArcherStats(ref float ArcherHP, ref float ArcherAtk, ref float ArcherDef)
        {
            ArcherHP = ArcherRandHp(ref ArcherHP);
            ArcherAtk = ArcherRandAtk(ref ArcherAtk);
            ArcherDef = ArcherRandDef(ref ArcherDef);
        }
    }
}