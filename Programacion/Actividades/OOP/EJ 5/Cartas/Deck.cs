using System;
using System.Drawing;

namespace Pruebas
{
    public class CardGame
    {
        private string gameType;

        public string GameType { get { return gameType; } set { gameType = value; } }

        public CardGame(string gameType)
        {
            GameType = gameType;
        }
    }
}
