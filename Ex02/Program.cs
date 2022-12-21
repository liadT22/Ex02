using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
    internal class Program
    {
        public static void Main()
        {
            GameManager newGame = new GameManager();
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
