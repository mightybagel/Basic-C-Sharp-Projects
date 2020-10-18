using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectFollowAlong
{
    public class Deck //Deck is a collection of card
    {
        /*
        public Deck()
        {
            //With this constructor, can add 52 cards to the deck without writing the codes in the main function program
            Cards = new List<Card>();
            Card cardOne = new Card();
            cardOne.Face = "Two";
            cardOne.Suits = "Hearts";
            Cards.Add(cardOne);
        }
        */
        //Each deck has 13 cards (face): Ace, 2,3,4,...,K. Each card has 4 suits: hearts, diamond, spade and, club. Each face loops through 4 times. 
        //results in a nested loop to create a constructor to add multiple cards without writing repeated codes
        //13 *4 = 52 cards
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
        {
            "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
        };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suits = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        

        public List<Card> Cards { get; set; }
            
    }
}
