﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectFollowAlong
{
    public class TweentyOneGame : Game, IWalkAway
    { 
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
        
    }
}
