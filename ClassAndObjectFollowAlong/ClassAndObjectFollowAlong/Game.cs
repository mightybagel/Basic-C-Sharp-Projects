using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectFollowAlong
{
    //Create a generic class to establish inheritances
    //Named class in generic form to increase reusability
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; } //Name of game
        public string Dealer { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
