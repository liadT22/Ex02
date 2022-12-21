using System;

namespace Ex02
{
    public class GameData
    {
        public int mBoardSize;
        public eBoxStatuses[,] mBoxStatusMatrix;
        public bool mPlayerTurn;
        public bool mIsComputer;

        public GameData(int i_BoardSize, bool i_IsComputer)
        {
            this.mBoardSize = i_BoardSize;
            this.mBoxStatusMatrix = new eBoxStatuses[i_BoardSize, i_BoardSize];
            this.mIsComputer = i_IsComputer;
            this.mPlayerTurn = false;
        }
    }
}
