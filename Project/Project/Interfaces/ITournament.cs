using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    public interface ITournament : IEnumerator<Match>//represents a Tournament
    {
        bool AddPlayer(Player[] player);//returns true if the player or team was succesfully added to Tournament, false otherwise
        bool Teams { get; }//returns true if tournament can be playd in teams
        bool End { get; }//returns true if the Tournament ended
        Player[] ChWinner { get; }// returns the winner/s of the Tournament


    }
}
