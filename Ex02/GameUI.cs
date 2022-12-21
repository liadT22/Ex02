using System;

namespace Ex02
{
    internal class GameUI
    {
        public static void PrintBox(eBoxStatuses[,] i_BoxStatusMatrix, int i_BoardSize)
        {
            char topBoardLetter = 'A';
            Console.Write("    ");
            for (int i = 0; i <= i_BoardSize; i++)
            {
                for (int k = 0; k < i_BoardSize; k++)
                {
                    if (i == 0)
                    {
                        Console.Write(string.Format("  {0} ", topBoardLetter));
                        topBoardLetter++;
                    }
                    else if (k == 0)
                    {
                        Console.Write(string.Format(" {0}  |", i));
                        printBoxStatus(i_BoxStatusMatrix[i - 1, k]);
                    }
                    else
                    {
                        printBoxStatus(i_BoxStatusMatrix[i - 1, k]);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("    =================================");
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
                    Console.Write(" X |");
                    break;
                case eBoxStatuses.PlayerTwo:
                    Console.Write(" O |");
                    break;
            }
        }
    }
}
