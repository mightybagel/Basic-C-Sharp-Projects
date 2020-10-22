using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck, 3);


            //foreach(Card item in deck.Cards)
            //{
            //    Console.WriteLine(item.Face + " " + item.Suit);
            //}
            //Console.ReadLine();
        }
        
        public static Deck Shuffle(Deck deck)
        {
            var random = new Random();
            List<Card> Temp = new List<Card>();
             
           while (deck.Cards.Count > 0)
           {
                int i = random.Next(0, deck.Cards.Count);
                Temp.Add(deck.Cards[i]);
                deck.Cards.RemoveAt(i);
           }
            deck.Cards = Temp;

            return deck;
        }

        public static Deck Shuffle (Deck deck, int times)
        {
            for (int i = 0; i < times; i++)
            {
                deck = Shuffle(deck);
            }
            return deck;

        }
    }
}
