using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Club", "Spade", "Heart", "Diamond" };
            List<string> Faces = new List<string>() 
            { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            foreach (string suit in Faces)
            {
                foreach (string face in Suits)
                {
                    Card card = new Card
                    { 
                        Suit = suit,
                        Face = face
                    };
                    Cards.Add(card);
                    
                }
            }
        }

        public List<Card> Cards { get; set; }
    }
}
