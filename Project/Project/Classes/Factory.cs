using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project
{
    public class Factory //creates different types of object
    {
        public static IGame GamesFactory(string gameName, ILogger logger)//creates a type IGame
        {
            IGame game = null;
            switch (gameName)
            {
                case "Tic-Tac-Toe": game = new TicTacToe(logger); break;
            }
            return game;

        }

        public static ITournament TournamentFactory(string champName, ILogger logger, IGame game, int maxPoints, bool typeMatch)//creates a type ITournament
        {
            ITournament champ = null;
            switch (champName)
            {
                case "Title": champ = new TitleTournament(game, maxPoints, typeMatch, logger); break;
                case "Two To Two": champ = new TwoToTwoTournament(game, maxPoints, typeMatch, logger); break;
            }
            return champ;
        }

        public static Player PlayersFactory(string playerName, string playerTactic)//creates a type player
        {
            Player player = null;

            switch (playerTactic)
            {
                case "Random": player = new RandomPlayer(playerName); break;
                case "Greedy": player = new GreedyPlayer(playerName); break;
            }

            return player;
        }
    }
}
