using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    public class TwoToTwoTournament : ITournament
    {
        List<Player[]> Players;
        List<List<Player[]>> Combinations;
        int count;
        int MatchMaxPoints;
        bool MatchType;
        IGame Game;
        int[] Points;
        Match currentMatch;
        ILogger Log;
        bool Playing;
        bool firstPlaying;

        public TwoToTwoTournament() { }

        /*
      constructor parameters:
      -Game from which the Tournament is going to be made
      -Maximun number of point a player can achieve in a Match
      -True if the organization of the Matches is by game, false if it is by points
      -An object to log
      */
        public TwoToTwoTournament(IGame game, int matchMaxPoints, bool match, ILogger log)
        {
            Game = game;
            if (Game.NumberPlayers < 2)
                Log.Log("error", "Tournament", "The Tournament has to admit more than two players");
            MatchMaxPoints = matchMaxPoints;
            MatchType = match;
            Players = new List<Player[]>();
            Combinations = new List<List<Player[]>>();
            Log = log;
            Playing = false;
            firstPlaying = false;
        }

        #region IChampionship
        public bool AddPlayer(Player[] player) //returns true if the player or team was succesfully added to Tournament, false otherwise
        {
            if (player.Length == 0) { Log.Log("warning", "Tournament", "You did not add any player/s"); return false; }
            Players.Add(player);
            return true;
        }
        public bool End
        {
            get
            {
                return count == Combinations.Count;

            }
        }//returns true if the Tournament ended
        public Player[] ChWinner
        {
            get
            {
                int counter = 0;

                for (int i = 0; i < Points.Length; i++)
                {
                    if (Points[i] == Points[0]) { counter++; }
                }

                if (counter == 1) return Players[0];
                return null;
            }
        } // returns the winner/s of the Tournament

        #region IEnumerator
        public Match Current
        {
            get
            {
                if (!firstPlaying) Log.Log("warning", "Tournament", "You have not click the Play button");
                if (!Playing) Log.Log("warning", "Tournament", "The Tournament is over");
                return currentMatch;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool Teams //returns true if tournament can be playd in teams
        {
            get
            {
                return true;
            }
        }

        public bool MoveNext()
        {
            firstPlaying = true;
            if (Players.Count < 2) { Log.Log("error", "Tournament", "There are not enough players to start the Tournament"); return false; }
            if (count == 0)
            {
                Log.Log("info", "Tournament", "Two To Two Tournament has started");
                Combinations = Combinatoria(2, Players);
                Points = new int[Players.Count];
            }
            if (!End)
            {
                if (count!=0)
                {
                    if (currentMatch.MatchWinner == null)
                    {
                        for (int i = 0; i < Combinations[count].Count; i++)
                        {
                            Points[Players.IndexOf(Combinations[count][i])]++;
                        }
                    }
                    else Points[Players.IndexOf(currentMatch.MatchWinner)] += 2;
                }

                currentMatch = PlayMatch();
                count++;
                return Playing = true;
            }

            Log.Log("info", "Tournament", "Two To Two Tournament results: \n" + LogPlayerScale());
            Log.Log("info", "Tournament", "Two To Two Tournament is over \n");
            return Playing = false;
        }

        public void Dispose()
        {

        }
        public void Reset()
        {
            count = 0;
            Players = new List<Player[]>();
            Playing = false;
            firstPlaying = false;
            Game.Reset();
        }

        #endregion

        #endregion

        private Match PlayMatch() // initializes the player/s of the current Match
        {
            Game.Reset();
            Match a = new Match(Game, MatchMaxPoints, MatchType, Log);
            for (int i = 0; i < Combinations[count].Count; i++)
            {
                a.AddPlayer(Combinations[count][i]);
            }
            return a;

        }
        private void PlayerScale()//orders the final result of the Tournament
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = i + 1; j < Points.Length; j++)
                {
                    if (Points[i] < Points[j])
                    {
                        int tempPoints = Points[i]; Player[] tempPlayers = Players[i];
                        Points[i] = Points[j]; Players[i] = Players[j];
                        Points[j] = tempPoints; Players[j] = tempPlayers;
                    }
                }
            }
        }
        private string LogPlayerScale()//logs the final result of the Tournament
        {
            string result = "";
            for (int i = 0; i < Players.Count; i++)
            {
                for (int j = 0; j < Players[i].Length; j++)
                {
                    result += "|" + Players[i][j].Name + "|";
                }
                result += $"{Points[i]}\n";
            }
            return result;

        }

        #region AuxiliaryMethods
        private static List<List<Player[]>> Combinatoria(int k, List<Player[]> elems)//returns a list with all possible combination of players
        {
            List<List<Player[]>> result = new List<List<Player[]>>();
            Combinatoria(k, elems, ref result, new List<Player[]>(), 0);

            return result;

        }
        private static void Combinatoria(int k, List<Player[]> elems, ref List<List<Player[]>> result, List<Player[]> comb, int pos)
        {
            if (k == 0)
            {
                List<Player[]> tem = new List<Player[]>();
                foreach (var item in comb) tem.Add(item);
                result.Add(tem);
                return;
            }
            if (pos == elems.Count) return;

            List<Player[]> temp = Add(comb, elems, pos);
            Combinatoria(k - 1, elems, ref result, temp, pos + 1);
            comb.RemoveAt(comb.Count - 1);
            Combinatoria(k, elems, ref result, comb, pos + 1);
        }
        private static List<Player[]> Add(List<Player[]> comb, List<Player[]> elems, int pos) { comb.Add(elems[pos]); return comb; }
        #endregion
    }
}
