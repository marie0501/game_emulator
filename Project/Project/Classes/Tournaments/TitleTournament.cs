using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project
{
    public class TitleTournament : ITournament
    {
        List<Player[]> Players;
        IGame Game;
        int count;
        int countPlayers;
        int MatchMaxPoints;
        bool MatchType;
        int[] Points;
        Match currentMatch;
        Player[] currentWinner;
        ILogger Log;
        bool Playing;
        bool firstPlaying;

        public TitleTournament() { }

        /*
       constructor parameters:
       -Game from which the Tournament is going to be made
       -Maximun number of point a player can achieve in a Match
       -True if the organization of the Matches is by game, false if it is by points
       -An object to log
       */
        public TitleTournament(IGame game, int maxMatchPoints, bool match, ILogger log)
        {
            Players = new List<Player[]>();
            Game = game;
            MatchMaxPoints = maxMatchPoints;
            MatchType = match;
            count = 0;
            countPlayers = 0;
            Log = log;
            Playing = false;
            firstPlaying = false;

        }

        #region IChampionship
        public bool AddPlayer(Player[] player)//returns true if the player or team was succesfully added to Tournament, false otherwise
        {
            if (player.Length == 0) { Log.Log("warning", "Tournament", "You have not added any players"); return false; }
            if (player.Length != 1) { Log.Log("error", "Tournament", "Title Tournament is played individually"); return false; }
            Players.Add(player);
            return true;
        }

        public bool End //returns true if the Tournament ended
        {
            get
            {
                return countPlayers == Players.Count() - 1;
            }
        }
        public Player[] ChWinner // returns the winner/s of the Tournament
        {
            get
            {
                return currentWinner;
            }
        }


        #region IEnumerator
        public Match Current
        {
            get
            {
                if (!firstPlaying) Log.Log("warning", "Tournament", "You have not click the Play Tournament button");
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

        public bool Teams//returns true if tournament can be playd in teams
        {
            get
            {
                return false;
            }
        }

        public bool MoveNext()
        {
            firstPlaying = true;
            if (Players.Count < 2) Log.Log("warning", "Tournament", "There are not enough players to start the Tournament");
            if (count == 0)
            {
                currentWinner = Players[0]; Points = new int[Players.Count]; Log.Log("info", "Tournament", "Title Tournament has started");
            }
            else if (currentMatch.MatchWinner != null) { countPlayers++; currentWinner = currentMatch.MatchWinner; Points = new int[Players.Count]; }
            if (!End)
            {
                currentMatch = PlayMatch();
                count++;
                return Playing = true;
            }

            Log.Log("info", "Tournament", LogWinners(ChWinner));
            Log.Log("info", "Tournament", "Title Tournament is over \n");
            return Playing = false;
        }
        public void Dispose()
        {

        }

        public void Reset()
        {
            count = 0;
            Players = new List<Player[]>();
            countPlayers = 1;
            Playing = false;
            firstPlaying = false;
            Game.Reset();
        }

        #endregion

        #endregion

        private Match PlayMatch() //initializes the player/s of the current Match
        {
            Game.Reset();
            Match n = new Match(Game, MatchMaxPoints, MatchType, Log);
            n.AddPlayer(currentWinner);
            n.AddPlayer(Players[countPlayers + 1]);

            return n;
        }

        private static string LogWinners(Player[] winner)//logs the Tournament winner/s
        {
            string result = "";
            for (int i = 0; i < winner.Length; i++)
            {
                result += " | " + winner[i].Name + " | ";
            }
            return $"Title Tournament Winner: {result}";

        }

    }
}
