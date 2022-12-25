using System;

namespace Ex02
{
    internal class SystemControl
    {
        public static void StartGame()
        {
            string move;
            GameDataControl gameDataControl = new GameDataControl();
            GameData gameData = GameChatUI.Initial();
            Console.WriteLine("Player 1: " + gameData.PlayerOneName);
            Console.WriteLine("Player 2: " + gameData.PlayerTwoName);
            GameUI.PrintBox(gameData);
            while (gameDataControl.AnyExistingMove(gameData))
            {
                move = GameChatUI.AskCurrentPlayerForMove(gameData);
                if (gameDataControl.IsNewMoveValid(gameData, move))
                {
                    gameData = gameDataControl.EnterMoveToData(gameData, move);
                    gameData.ChangeTurn();
                    if (gameData.IsPlayerTwoComputer)
                    {
                        gameData = gameDataControl.ComputerTurn(gameData);
                        gameData.ChangeTurn();
                    }

                    GameUI.PrintBox(gameData);
                }
            }
        }
    }
}
