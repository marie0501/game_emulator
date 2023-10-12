using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project
{
    public class GreedyPlayer : Player, ITicTacToe//player who has an especific tactic, plays the best play
    {
        public GreedyPlayer() { }
        public GreedyPlayer(string name) : base(name) { }

        public void Play()
        {
            return;
        }

        public int[] Play(TicTacToe game) //implementation of the interface ITicTacToe, it means thi type of player knows how to play TicTacToe
        {
            return game.PlayBest();
        }
    }
}
