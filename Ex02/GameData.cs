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

        internal eBoxStatuses[,] m_BoxStatusMatrix;
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

        internal eTurns m_PlayerTurn;
        private bool m_IsPlayerTwoComputer;

        public bool IsPlayerTwoComputer
        {
            get { return this.m_IsPlayerTwoComputer; }
        }

        public GameData(int i_BoardSize, bool i_IsPlayerTwoComputer, string i_PlayerOneName, string i_PlayerTwoName)
        {
            this.m_BoardSize = i_BoardSize;
            this.m_BoxStatusMatrix = initBoard(i_BoardSize);
            this.m_IsPlayerTwoComputer = i_IsPlayerTwoComputer;
            this.m_PlayerTurn = eTurns.PlayerOneTurn;
            this.PlayerOneName = i_PlayerOneName;
            this.PlayerTwoName = i_PlayerTwoName;
        }

        public void ChangeTurn()
        {
            this.m_PlayerTurn = this.m_PlayerTurn == eTurns.PlayerOneTurn ? eTurns.PlayerTwoTurn : eTurns.PlayerOneTurn;
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

    internal enum eTurns
    {
        PlayerOneTurn,
        PlayerTwoTurn
    }

    internal enum eBoxStatuses
    {
        Natural,
        PlayerOne,
        PlayerTwo
    }
}
