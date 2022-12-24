using System;

namespace Ex02
{
    internal class GameChatUI
    {
        public static GameData Initial()
        {
            int boardSize;
            bool isPlayerTwoComputer;
            string nameOfPlayer1;
            string nameOfPlayer2 = null;
            string playerChoice;
            Console.WriteLine("Enter player 1 name: ");
            nameOfPlayer1 = Console.ReadLine();
            while (nameOfPlayer1 == string.Empty)
            {
                Console.WriteLine("Please enter player 1 name: ");
                nameOfPlayer1 = Console.ReadLine();
            }

            Console.WriteLine(@"Who would you like to play with? 
1. Player 2 -> choose number 1
2. Computer -> choose number 2
");
            playerChoice = Console.ReadLine();
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Please enter a valid value");
                playerChoice = Console.ReadLine();
            }

            if (playerChoice == "1")
            {
                Console.WriteLine("Enter player 2 name: ");
                nameOfPlayer2 = Console.ReadLine();
                while (nameOfPlayer2 == string.Empty)
                {
                    Console.WriteLine("Please enter player 1 name: ");
                    nameOfPlayer2 = Console.ReadLine();
                }

                isPlayerTwoComputer = false;
            }
            else
            {
                Console.WriteLine("Good luck in your game against the computer");
                isPlayerTwoComputer = true;
            }

            Console.WriteLine(@"Please Choose the size of the game: 
1. 6X6 -> Choose 1
2. 8X8 -> Choose 2
");
            playerChoice = Console.ReadLine();
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Please Enter valid value");
                playerChoice = Console.ReadLine();
            }

            if (playerChoice == "1")
            {
                boardSize = 6;
            }
            else
            {
                boardSize = 8;
            }

            return new GameData(boardSize, isPlayerTwoComputer, nameOfPlayer1, nameOfPlayer2);
        }
    }
}