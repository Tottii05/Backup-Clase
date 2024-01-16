using System;

namespace Control
{
    public class Check
    {
        public static bool MenuChoiceInput(int menuChoice, ref int menuTries)
        {
            const string MenuWrongChoice = "Elegiste un valor no permitido prueba otra vez, te quedan estos intentos: {0} ";
            const string Bye = "Hasta pronto! :D ";
            const string Play = "Perfecto, vamos a jugar!";

            if (menuChoice == 0)
            {
                Console.WriteLine(Bye);
                return true;
            }
            else if (menuChoice == 1)
            {
                Console.WriteLine(Play);
                return true;
            }
            else
            {
                Console.WriteLine(MenuWrongChoice, menuTries-1);
                menuTries--;
                return false;
            }
        }

        public static bool MenuTriesLeft(int menuTries, int menuChoice, ref bool leaveMenu)
        {
            const string MenuOutOftries = "Te quedaste sin intentos en un menú, madre mía...";
            if (menuChoice == 0)
            {
                return leaveMenu = true;
            }
            else
            {
                if (menuTries == 0)
                {
                    Console.WriteLine(MenuOutOftries);
                    return leaveMenu = true;
                }
                else
                {
                    return leaveMenu = false;
                }
            }
        }

        public static void TriesLeft(int tries, float statValue, int minValue, ref bool StatCreated)
        {
            if (tries == 0)
            {
                statValue = minValue;
                StatCreated = true;
            }
        }
    }
}
