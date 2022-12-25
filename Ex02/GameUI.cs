using System;

namespace Ex02
{
    public class GameUI
    {
        public static void PrintBox(GameData i_data)
        {
            char topBoardLetter = 'A';
            Console.Write("    ");
            for (int i = 0; i <= i_data.BoardSize; i++)
            {
                for (int k = 0; k < i_data.BoardSize; k++)
                {
                    if (i == 0)
                    {
                        Console.Write(string.Format("  {0} ", topBoardLetter));
                        topBoardLetter++;
                    }
                    else if (k == 0)
                    {
                        Console.Write(string.Format(" {0}  |", i));
                        printBoxStatus(i_data.m_BoxStatusMatrix[i - 1, k]);
                    }
                    else
                    {
                        printBoxStatus(i_data.m_BoxStatusMatrix[i - 1, k]);
                    }
                }

                Console.WriteLine();
                Console.Write("    ");
                for (int j = 0; j < i_data.BoardSize; j++)
                {
                    Console.Write("====");
                }

                Console.WriteLine("=");
            }
        }

        private static void printBoxStatus(eBoxStatuses status)
        {
            switch (status)
            {
                case eBoxStatuses.Natural:
                    Console.Write("   |");
                    break;
                case eBoxStatuses.PlayerOne:
                    Console.Write(" O |");
                    break;
                case eBoxStatuses.PlayerTwo:
                    Console.Write(" X |");
                    break;
            }
        }
    }
}
