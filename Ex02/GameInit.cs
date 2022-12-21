using System;

namespace Ex02
{
    internal class GameInit
    {
        public static void Initial(out string o_NameOfPlayer1, out string o_NameOfPlayer2, out bool o_IsPlayerTwoComputer, out int o_GameSize)
        {
            o_IsPlayerTwoComputer = true;
            o_NameOfPlayer2 = null;
            string playerChoice = null;
            Console.WriteLine("Enter your name: ");
            o_NameOfPlayer1 = Console.ReadLine();
            Console.WriteLine(@"Who would you like to play with? 
            1. Player2 -> choose number 1
            2. Computer -> choose number 2");
            playerChoice = Console.ReadLine();
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Please enter a valid value");
                playerChoice = Console.ReadLine();
            }

            if (playerChoice == "1")
            {
                Console.WriteLine("Enter the second player name: ");
                o_NameOfPlayer2 = Console.ReadLine();
                o_IsPlayerTwoComputer = false;
            }

            if (playerChoice == "2")
            {
                Console.WriteLine("Good luck in your game against the computer");
            }

            Console.WriteLine(@"Please Choose the size of the game: 
            1. 6X6 -> Choose 1
            2. 8X8 -> Choose 2");
            playerChoice = Console.ReadLine();
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Please Enter valid value");
                playerChoice = Console.ReadLine();
            }

            if (playerChoice == "1")
            {
                o_GameSize = 6;
            }
            else
            {
                o_GameSize = 8;
            }
        }
    }
}