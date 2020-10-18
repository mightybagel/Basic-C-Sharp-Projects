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


        //Added method
        //Modify this shuffle method to use optional parameter instead of overload method
        //Modify this shuffle method to use optional parameter, OUT PARAMETER instead of overload method
        //Moved the shuffle method to deck.cs because this is behavior of deck
        public void  Shuffle(int times = 1)
        //demonstrate for OUT PARAMETER added out int timeShuffled
        //Assigned times = 1 means assign the default value 
        //--> that is how to create an optional parameter by assign a default value 1 to time (time = 1 )                              
        {

            for (int i = 0; i < times; i++)
            {

                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);

                }
                this.Cards = TempList;
            }
            
            //Since this is a method of deck, do not need static
            //Removed deck because it operates in the deck.cs
            //Removed out parameter timeshuffled
            //Replace with this b/c it refers to itself
            //Removed return because it is internal no need return anything
        } 

    }
}
