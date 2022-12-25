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
            ConsoleUtils.Screen.Clear();
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

        public static string AskCurrentPlayerForMove(GameData i_GameData)
        {
            string playerMove;
            if (i_GameData.m_PlayerTurn == eTurns.PlayerOneTurn)
            {
                playerMove = getValidMove(i_GameData.PlayerOneName, i_GameData.BoardSize);
            }
            else
            {
                playerMove = getValidMove(i_GameData.PlayerTwoName, i_GameData.BoardSize);
            }

            return playerMove;
        }

        public static void IllegalMoveInput(string i_Move)
        {
            Console.WriteLine(string.Format(
                "{0} is not one of your options as a move, look again at the board and enter a new move", i_Move));
        }

        public static void OutOfMovesForCurrentPlayer(string i_CurrentPlayerName)
        {
            Console.WriteLine(string.Format("It looks like {0} doesn't have any legal move to make", i_CurrentPlayerName));
        }

        public static bool GameOverAndCheckRestart(string i_winnerName, bool i_IsTie, int i_PlayerOneScore, int i_PlayerTwoScore)
        {
            bool isNewGame = false;
            string playerChoice;
            if (i_IsTie)
            {
                Console.WriteLine(string.Format(
                @"It's a tie! so no winners..
you are both with {0} points.
Would you like to play another game?
1. Yes -> Choose 1
2. No -> Choose 2", i_PlayerOneScore));
            }
            else
            {
                Console.WriteLine(string.Format(
                @"congratulations {0}! You are the winner!
Player 1 with: {1} points, and Player 2 with {2} points.
Would you like to play another game?
1. Yes -> Choose 1
2. No -> Choose 2", i_winnerName, i_PlayerOneScore, i_PlayerTwoScore));
            }

            playerChoice = Console.ReadLine();
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Please Enter valid value");
                playerChoice = Console.ReadLine();
            }

            if (playerChoice == "1")
            {
                isNewGame = true;
            }

            return isNewGame;
        }

        private static string getValidMove(string i_PlayerName, int i_BoardSize)
        {
            string playerMove;
            bool isValidMove = false;
            Console.WriteLine(string.Format(
                    @"Hello {0}, what is your move?
Your move must be a letter and a number that fit the board (IE: a2, B3, etc...)
(Note: you can also Type {1} to exit)", i_PlayerName, Global.v_ExitGame));
            playerMove = Console.ReadLine();
            if (playerMove == Global.v_ExitGame || playerMove == Global.v_ExitGame.ToLower())
            {
                playerMove = playerMove.ToUpper();
                isValidMove = true;
            }

            while (isValidMove == false)
            {
                isValidMove = true;
                if (playerMove.Length != 2)
                {
                    Console.WriteLine("Please enter a valid move (IE: a2, B3, etc....)");
                    isValidMove = false;
                }
                else
                {
                    playerMove = playerMove.ToUpper();
                    if (char.IsDigit(playerMove[1]) == false || (playerMove[1] < '1' || playerMove[1] >= (char)('1' + i_BoardSize)))
                    {
                        Console.WriteLine("Please make sure your second input is a valid digit!");
                        isValidMove = false;
                    }

                    if (char.IsLetter(playerMove[0]) == false || (playerMove[0] < 'A' || playerMove[0] >= (char)('A' + i_BoardSize)))
                    {
                        Console.WriteLine("Please make sure your first input is a valid letter!");
                        isValidMove = false;
                    }
                }

                if (playerMove == Global.v_ExitGame || playerMove == Global.v_ExitGame.ToLower())
                {
                    playerMove = playerMove.ToUpper();
                    isValidMove = true;
                }
                else if (isValidMove == false)
                {
                    Console.WriteLine("Please enter your move again:");
                    playerMove = Console.ReadLine();
                }
            }

            return playerMove;
        }
    }
}