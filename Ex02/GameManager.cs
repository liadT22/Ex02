using System;

namespace Ex02
{
    internal class GameManager
    {
        GameData game = null;

        public GameManager()
        {
            string nameOfPlayer1, nameOfPlayer2;
            bool isPlayerTwoComputer;
            int gameSize;
            GameInit.Initial(out nameOfPlayer1, out nameOfPlayer2, out isPlayerTwoComputer, out gameSize);
            this.game = new GameData(gameSize, isPlayerTwoComputer);
            GameUI.PrintBox(game.mBoxStatusMatrix, game.mBoardSize);
        }

    }
}
