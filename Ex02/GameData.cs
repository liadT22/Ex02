using System;

namespace Ex02
{
    public class GameData
    {
        private int m_BoardSize;

        public int BoardSize
        {
            get
            {
                return this.m_BoardSize;
            }
        }

        private eBoxStatuses[,] m_BoxStatusMatrix;

        public eBoxStatuses[,] BoxStatusMatrix
        {
            get
            {
                return this.m_BoxStatusMatrix;
            }

            set
            {
                this.m_BoxStatusMatrix = value;
            }
        }

        private string m_PlayerOneName;

        public string PlayerOneName
        {
            get
            {
                return this.m_PlayerOneName;
            }

            set
            {
                if (value.Length == 1)
                {
                    this.m_PlayerOneName = value.ToUpper();
                }
                else
                {
                    this.m_PlayerOneName = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }

        private string m_PlayerTwoName;

        public string PlayerTwoName
        {
            get
            {
                return this.m_PlayerTwoName;
            }

            set
            {
                if (value == null)
                {
                    this.m_PlayerTwoName = null;
                }
                else if (value.Length == 1)
                {
                    this.m_PlayerTwoName = value.ToUpper();
                }
                else
                {
                    this.m_PlayerTwoName = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }

        private eTurns m_PlayerTurn;

        public eTurns PlayerTurn
        {
            get
            {
                if (this.m_PlayerTurn == eTurns.PlayerOneTurn)
                {
                    this.m_PlayerTurn = eTurns.PlayerTwoTurn;
                    return eTurns.PlayerOneTurn;
                }
                else
                {
                    this.m_PlayerTurn = eTurns.PlayerOneTurn;
                    return eTurns.PlayerTwoTurn;
                }
            }

            set
            {
                this.m_PlayerTurn = value;
            }
        }

        private bool m_IsPlayerTwoComputer;

        public bool IsPlayerTwoComputer
        {
            get { return this.m_IsPlayerTwoComputer; }
        }

        public GameData(int i_BoardSize, bool i_IsPlayerTwoComputer, string i_PlayerOneName, string i_PlayerTwoName)
        {
            this.m_BoardSize = i_BoardSize; // maybe remove?
            this.m_BoxStatusMatrix = initBoard(i_BoardSize);
            this.m_IsPlayerTwoComputer = i_IsPlayerTwoComputer;
            this.m_PlayerTurn = eTurns.PlayerOneTurn;
            this.PlayerOneName = i_PlayerOneName;
            this.PlayerTwoName = i_PlayerTwoName;
        }

        private static eBoxStatuses[,] initBoard(int i_boardSize)
        {
            eBoxStatuses[,] boxStatusMatrix = new eBoxStatuses[i_boardSize, i_boardSize];
            boxStatusMatrix[(i_boardSize / 2) - 1, (i_boardSize / 2) - 1] = eBoxStatuses.PlayerOne;
            boxStatusMatrix[i_boardSize / 2, i_boardSize / 2] = eBoxStatuses.PlayerOne;
            boxStatusMatrix[(i_boardSize / 2) - 1, i_boardSize / 2] = eBoxStatuses.PlayerTwo;
            boxStatusMatrix[i_boardSize / 2, (i_boardSize / 2) - 1] = eBoxStatuses.PlayerTwo;
            return boxStatusMatrix;
        }
    }

    public enum eTurns
    {
        PlayerOneTurn,
        PlayerTwoTurn
    }

    public enum eBoxStatuses
    {
        Natural,
        PlayerOne,
        PlayerTwo
    }
}
