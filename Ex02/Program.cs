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
            eBoxStatuses[,] mBoxStatusMatrix = new eBoxStatuses[number, number];
            mBoxStatusMatrix[0, 0] = eBoxStatuses.PlayerOne;
            mBoxStatusMatrix[0, 7] = eBoxStatuses.PlayerOne;
            mBoxStatusMatrix[7, 0] = eBoxStatuses.PlayerOne;
            mBoxStatusMatrix[7, 7] = eBoxStatuses.PlayerOne;
            mBoxStatusMatrix[3, 3] = eBoxStatuses.PlayerOne;
            mBoxStatusMatrix[4, 4] = eBoxStatuses.PlayerOne;
            mBoxStatusMatrix[4, 3] = eBoxStatuses.PlayerTwo;
            mBoxStatusMatrix[3, 4] = eBoxStatuses.PlayerTwo;
            GameUI.PrintBox(mBoxStatusMatrix, 8);
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
