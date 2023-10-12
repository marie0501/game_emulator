using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class Player
    {
        public Player() { }
        public Player(string name) { Name = name; }//constructor parameters: name of the player
        public string Name { get; set; }//name of the player
        
    }

   
}
