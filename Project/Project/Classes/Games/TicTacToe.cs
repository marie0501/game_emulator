using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TicTacToe : IGame
    {
        Cell[,] Matrix;
        List<Player[]> Players;
        Player[] winner;
        int count;
        int[] currentMove;
        ILogger Log;
        bool firstPlaying;
        bool Playing;

        public TicTacToe() { }
        public TicTacToe(ILogger log)
        {
            Matrix = new Cell[3, 3];
            Players = new List<Player[]>();
            count = 0;
            Log = log;
            firstPlaying = false;
            Playing = false;
        }
        private enum Cell { clean, X, O }

        #region IGame
        public int NumberPlayers //number of players needed
        {
            get
            {
                return 2;
            }
        }
        public int NumberTeams //number of team allowed
        {
            get
            {
                Log.Log("warning", "Game", "Tic Tac Toe is played individually");
                return -1;
            }
        }
        public int NumberOfPlayersPerTeam //number of player allowed per team
        {
            get
            {
                Log.Log("warning", "Game", "Tic Tac Toe is played individually");
                return -1;
            }
        }
        public bool Teams//returns true if the game can be played in teams, false otherwise
        {
            get
            {
                return false;
            }
        }
        public bool AddPlayer(Player[] g)//returns true if the player or team was succesfully added to Game, false otherwise
        {
            if (g.Length == 0) Log.Log("warning", "Game", "You have not addedd any player");
            if (g.Length != 1) Log.Log("warning", "Game", "Tic Tac Toe is played individually");
            if (Players.Count <= NumberPlayers) { Players.Add(g); return true; }
            return false;
        }
        public bool GameOver //returns true if the game is over, false otherwise
        {
            get
            {
                return (count == Matrix.Length || ThreeInLine());

            }
        }
        public Player[] GameWinner { get { return !ThreeInLine() ? null : winner; } } //returns th player or team that won the game
        public int WinnerPoints //number of points the winner of a game gets
        {
            get
            {
                return 1;
            }
        }

        public string GetInterface //returns the name of the interface asociated with the game
        {
            get
            {
                return "ITicTacToe";
            }
        }

        #region IEnumerator
        public object Current
        {
            get
            {
                if (!firstPlaying) Log.Log("warning", "Game", "You have not click the Play Game or Next Move button");
                if (!Playing) Log.Log("warning", "Game", "The Game is over");
                return currentMove;
            }
        }

       

        public bool MoveNext()
        {
            firstPlaying = true;
            if (Players.Count < NumberPlayers) Log.Log("warning", "Game", "There are not enough players to start the game");
            if (count == 0) Log.Log("info","Game", "Tic Tac Toe has started");
            if (!GameOver)
            {
                ITicTacToe currentPlayer = (ITicTacToe)Players[count % NumberPlayers][0];
                currentMove = currentPlayer.Play(this);
                Matrix[currentMove[0], currentMove[1]] = ((count % NumberPlayers) + 1) == 1 ? Cell.X : Cell.O;
                Log.Log("info", "Move", $"{Players[count % NumberPlayers][0].Name} played {(((count % NumberPlayers) + 1) == 1 ? Cell.X : Cell.O)} in cell [{currentMove[0]},{currentMove[1]}]");
                count++;
                return Playing = true;
            }

            Log.Log("info","Game", GameWinner != null ? $"Tic Tac Toe winner: | {GameWinner[0].Name} |" : "Tied Game");
            Log.Log("info","Game", "Tic Tac Toe is over \n");

            return Playing = false;
        }
        public void Reset()
        {
            count = 0;
            Matrix = new Cell[3, 3];
            currentMove = new int[2];
            Players = new List<Player[]>();
        }
        #endregion

        #endregion
        private bool ThreeInLine()
        {
            if (count < 4) return false;
            Cell current = Matrix[currentMove[0], currentMove[1]];
            if (Matrix[currentMove[0], 0] == current && Matrix[currentMove[0], 1] == current && Matrix[currentMove[0], 2] == current) { winner = Players[(count - 1) % Players.Count]; return true; }
            else if (Matrix[0, currentMove[1]] == current && Matrix[1, currentMove[1]] == current && Matrix[2, currentMove[1]] == current) { winner = Players[(count - 1) % Players.Count]; return true; }
            else if (Matrix[0, 0] == current && Matrix[1, 1] == current && Matrix[2, 2] == current) { winner = Players[(count - 1) % Players.Count]; return true; }
            else if (Matrix[0, 2] == current && Matrix[1, 1] == current && Matrix[2, 0] == current) { winner = Players[(count - 1) % Players.Count]; return true; }
            return false;
        }
        public int[] PlayBest()
        {
            int[] dr = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] dc = { -1, 0, 1, 1, 1, 0, -1, -1 };
            int max = int.MinValue;
            int[] result = new int[2];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    int points = 0;

                    if (Matrix[i, j] != Cell.clean) continue;

                    for (int k = 0; k < dr.Length; k++)
                    {
                        int nr = i + dr[k];
                        int nc = j + dc[k];
                        if (nr < 0 || nc < 0 || nr >= Matrix.GetLength(0) || nc >= Matrix.GetLength(1) || Matrix[nr, nc] != (((count % NumberPlayers) + 1) == 1 ? Cell.X : Cell.O)) continue;
                        points++;
                    }
                    if (points > max) { max = points; result[0] = i; result[1] = j; }
                }

            }
            return result;
        }//returns the best move of the current game
        public int[] PlayRandom()
        {
            Random r = new Random();
            int x = r.Next(0, Matrix.GetLength(0));
            int y = r.Next(0, Matrix.GetLength(1));
            while (Matrix[x, y] != Cell.clean) { x = r.Next(0, Matrix.GetLength(0)); y = r.Next(0, Matrix.GetLength(1)); }
            int[] result = { x, y };
            return result;

        }//returns a random valid move of the current game
        public bool Play(int[] playerMove)
        {
            return Matrix[playerMove[0], playerMove[1]] == Cell.clean;
        }//recieve the move a the current player

        
    }

    public interface ITicTacToe
    {
        int[] Play(TicTacToe game);
    }
}
