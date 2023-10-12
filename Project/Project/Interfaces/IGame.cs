using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public interface IGame : IEnumerator //represents a game
    {
        int NumberPlayers { get; }//number of players needed
        int NumberTeams { get; }//number of team allowed
        int NumberOfPlayersPerTeam { get; }//number of player allowed per team
        bool Teams { get; }//returns true if the game can be played in teams, false otherwise
        bool AddPlayer(Player[] g);//returns true if the player or team was succesfully added to Game, false otherwise
        bool GameOver { get; }//returns true if the game is over, false otherwise
        int WinnerPoints { get; }//number of points the winner of a game gets
        Player[] GameWinner { get; }//returns th player or team that won the game
        string GetInterface { get; }//returns the name of the interface asociated with the game

    }
}
