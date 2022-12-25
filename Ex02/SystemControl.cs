using System;
using System.Security.Permissions;

namespace Ex02
{
    internal class SystemControl
    {

        public static void StartGame()
        {
            string move, currentPlayerName, winnerName;
            int playerOneScore, playerTwoScore;
            bool isTie;
            bool gameOver = false;
            int checkIfGameOver = 0;
            GameDataControl gameDataControl = new GameDataControl();
            GameData gameData = GameChatUI.Initial();
            GameUI.PrintBoard(gameData);
            while (!gameOver)
            {
                if (gameDataControl.AnyExistingMove(gameData))
                {
                    checkIfGameOver = 0;
                    if (gameData.IsPlayerTwoComputer && gameData.m_PlayerTurn == eTurns.PlayerTwoTurn)
                    {
                        gameData = gameDataControl.ComputerTurn(gameData);
                    }
                    else
                    {
                        move = GameChatUI.AskCurrentPlayerForMove(gameData);
                        if (move == Global.v_ExitGame)
                        {
                            gameOver = true;
                        }
                        else
                        {
                            while (!gameOver && !gameDataControl.IsNewMoveValid(gameData, move))
                            {
                                if (move == Global.v_ExitGame)
                                {
                                    gameOver = true;
                                }
                                else
                                {
                                    GameChatUI.IllegalMoveInput(move);
                                    move = GameChatUI.AskCurrentPlayerForMove(gameData);
                                }
                            }

                            if (move != Global.v_ExitGame)
                            {
                                gameData = gameDataControl.EnterMoveToData(gameData, move);
                            }
                        }
                    }

                    gameData.ChangeTurn();
                    GameUI.PrintBoard(gameData);
                }
                else
                {
                    checkIfGameOver++;
                    if (checkIfGameOver == 2)
                    {
                        winnerName = gameDataControl.CalcWinner(gameData, out playerOneScore, out playerTwoScore, out isTie);
                        if (GameChatUI.GameOverAndCheckRestart(winnerName, isTie, playerOneScore, playerTwoScore))
                        {
                            gameData = GameChatUI.Initial();
                            GameUI.PrintBoard(gameData);
                        }
                        else
                        {
                            gameOver = true;
                        }
                    }
                    else
                    {
                        currentPlayerName = gameData.m_PlayerTurn == eTurns.PlayerOneTurn ? gameData.PlayerOneName : gameData.PlayerTwoName;
                        GameChatUI.OutOfMovesForCurrentPlayer(currentPlayerName);
                        gameData.ChangeTurn();
                    }
                }
            }
        }
    }
}
