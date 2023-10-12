using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    public class RandomPlayer : Player, ITicTacToe //player who has an especific tactic, plays randomly
    {
        public RandomPlayer() { }
        public RandomPlayer(string name) : base(name) { }
        public int[] Play(TicTacToe game)//implementation of the interface ITicTacToe, it means thi type of player knows how to play TicTacToe
        {
            return game.PlayRandom();
        }
    }

    
}
