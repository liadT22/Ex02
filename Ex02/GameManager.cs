using System;

namespace Ex02
{
    internal class GameManager
    {
        public static void StartGame()
        {
            GameData data = GameChatUI.Initial();
            Console.WriteLine("Player 1: " + data.PlayerOneName);
            Console.WriteLine("Player 2: " + data.PlayerTwoName);
            GameUI.PrintBox(data);
            string move = GameChatUI.AskPlayerForMove(data);
            Console.WriteLine(move);
        }
    }
}
