using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
    internal class Program
    {
        public static void Main()
        {
            int number = 8;
            GameData game = new GameData(number, false);
            game.mBoxStatusMatrix[0, 0] = eBoxStatuses.PlayerOne;
            game.mBoxStatusMatrix[0, 7] = eBoxStatuses.PlayerOne;
            game.mBoxStatusMatrix[7, 0] = eBoxStatuses.PlayerOne;
            game.mBoxStatusMatrix[7, 7] = eBoxStatuses.PlayerOne;
            game.mBoxStatusMatrix[3, 3] = eBoxStatuses.PlayerOne;
            game.mBoxStatusMatrix[4, 4] = eBoxStatuses.PlayerOne;
            game.mBoxStatusMatrix[4, 3] = eBoxStatuses.PlayerTwo;
            game.mBoxStatusMatrix[3, 4] = eBoxStatuses.PlayerTwo;
            GameUI.PrintBox(game.mBoxStatusMatrix, 8);
            Console.ReadLine();
        }
    }

    public enum eBoxStatuses
    {
        Natural,
        PlayerOne,
        PlayerTwo
    }
}
