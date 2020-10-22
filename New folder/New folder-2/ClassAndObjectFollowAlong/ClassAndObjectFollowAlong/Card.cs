using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This used to create a blackjack (twenty one) game
namespace ClassAndObjectFollowAlong
{
    public class Card
    {
        //initialize an object upon creation is important. Doing that by creating an constructor 
        public Card()//always names constructor as class's name. Create a constructor before create  properties

        {
            Suits = "Spades";
            Face = "Two";
        }
        public string Suits { get; set; }//card has a suit feature: heart, diamond
        public string Face { get; set; }
        
       

    }
}
