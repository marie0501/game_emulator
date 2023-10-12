using System;
using System.Collections.Generic;
using System.CodeDom;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    public class Match : IEnumerator<IGame>
    {
        #region MatchFields
        int count;
        List<Player[]> Players;
        int[] Points;
        int GameWinnerPoints;
        int MaxNumberPoints;
        bool MatchType;
        IGame currentGame;
        ILogger Log;
        IGame Game;
        bool Playing;
        bool firstPlaying;
        #endregion

        /*
        constructor parameters:
        -Game from which the Match is going to be made
        -Maximun number of point a player can achieve
        -True if the organization of the Match is by game, false if it is by points
        -An object to log
        */

        public Match(IGame game, int maxPoints, bool typeMatch, ILogger log)
        {
            Game = game;
            MaxNumberPoints = maxPoints;
            MatchType = typeMatch;
            Log = log;
            count = 0;
            if (typeMatch) { GameWinnerPoints = 1; } else GameWinnerPoints = game.WinnerPoints;
            Players = new List<Player[]>();
            Points = new int[Game.NumberPlayers];
            Playing = false;
            firstPlaying = false;
        }

        public bool AddPlayer(Player[] p)
        {
            if (p.Length == 0) Log.Log("warning", "Match", "You have not added any player");
            if (Game.AddPlayer(p))
            {
                Players.Add(p); return true;
            }
            return false;
        }//returns true if the player or team was succesfully added to Match, false otherwise
        public Player[] MatchWinner
        {
            get
            {
                int count = 0;
                int pos = 0;

                for (int i = 0; i < Points.Length; i++)
                {
                    if (Points[i] == MaxNumberPoints) { count++; pos = i; }
                }

                if (count == 1) { return Players[pos]; }
                return null;
            }
        }//returns the player or team that wins the Match, in case of a tie, returns null
        private static string LogWinners(Player[] winner)
        {
            if (winner == null) return "Tied Match";
            string result = "";
            for (int i = 0; i < winner.Length; i++)
            {
                result += " | " + winner[i].Name + " | ";
            }
            return $"Match winner/s: {result}";

        }//returns in a string the names of the Match winners
        private void PlayGame()
        {
            Game.Reset();
            for (int i = 0; i < Players.Count; i++)
            {
                Game.AddPlayer(Players[i]);
            }
        }// initializes the player/s of the current game
        public bool MatchOver
        {
            get
            {
                return Points.Max() == MaxNumberPoints;
            }

        }//returns true if Match is over, false otherwise

        #region IEnumerator
        public IGame Current
        {
            get
            {
                if (!firstPlaying) Log.Log("warning", "Match", "You have not click the Play button");
                if (!Playing) Log.Log("error", "Match", "The Match is over");
                return currentGame;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            firstPlaying = true;
             if(count!=0)        
            {
                if (currentGame.GameOver)
                {
                    if (currentGame.GameWinner == null)
                    {
                        for (int i = 0; i < Points.Length; i++)
                        {
                            Points[i]++;
                        }
                    }
                    else Points[Players.IndexOf(currentGame.GameWinner)] += GameWinnerPoints;
                }
            }
            if (!MatchOver)
            {
                if (count == 0) Log.Log("info", "Match", "Match has started ");
                PlayGame();
                currentGame = Game;
                count++;
                return Playing = true;
            }

            Log.Log("info", "Match", LogWinners(MatchWinner));
            Log.Log("info", "Match", "Match is Over \n");
            return Playing = false;
        }
        public void Reset()
        {
            count = 0; Points = new int[Players.Count];
        }
        public void Dispose()
        {

        }
        #endregion


    }
}
