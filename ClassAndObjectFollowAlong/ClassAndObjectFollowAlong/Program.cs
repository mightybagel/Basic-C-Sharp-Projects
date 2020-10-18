using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This used to create a blackjack (twenty one) game
//wrench represents properties of an object
namespace ClassAndObjectFollowAlong //using the same name space with program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);//comment this to get the ordered deck

            /**********************************
            //Can replace the block of following codes by create a constructor in deck class to initialize a deck object
            deck.Cards = new List<Card>();
            Card cardOne = new Card();//Create a new empty instance of object 
            cardOne.Face = "Queen";
            cardOne.Suits = "Spades";//initialize object is important. Doing that by creating an constructor 
            //Add a card to the deck
            deck.Cards.Add(cardOne);
            **********************************/

            //Console.WriteLine(cardOne.Face + " of" + cardOne.Suits);
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suits);
            }
            Console.WriteLine(deck.Cards.Count);
           //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suits);
            Console.ReadLine();
        }
        //Added method
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);

            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
