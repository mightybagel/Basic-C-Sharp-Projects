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
            /********************
             Note3: Out parameter : out parameter doesn’t require the variables 
            to be initialized before it passed to the method. 
            But before it returns a value to the calling method, 
            the variable must be initialized in the called method.
            see: public static Deck Shuffle(Deck deck, int times = 1)

             ******************/

            Deck deck = new Deck();
            //deck = Shuffle(deck);//comment this to get the ordered deck


            /********************
             Note 2
             Name parameter: does not change anything 
             Easier to read
             deck: deck, time: 3 --> name parameter
            //deck = Shuffle(deck:deck, times: 3); 
             *******************/


            
            int timeShuffle = 0;
            deck = Shuffle(deck, out timeShuffle, 3);



            //deck = Shuffle(deck:deck, times: 3); 




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
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suits);
            }
            Console.WriteLine(deck.Cards.Count);
            //Easy way to format string: can add {1} after {0} and add another variable need to be formatted after timeshuffled
            Console.WriteLine("Time shuffled {0} ", timeShuffle);
            
           //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suits);
            Console.ReadLine();
        }

        //Added method
        //Modify this shuffle method to use optional parameter instead of overload method
        //Modify this shuffle method to use optional parameter, OUT PARAMETER instead of overload method
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
            //demonstrate for OUT PARAMETER added out int timeShuffled
                //Assigned times = 1 means assign the default value 
                //--> that is how to create an optional parameter by assign a default value 1 to time (time = 1 )                              
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);

                }
                deck.Cards = TempList;
            }
            return deck;
        }
        //Overload method: when function is similar. shuffle multiple times similar to shuffle
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        /********************************
         Note1:
         Sometimes it is better to get optional parameter when there is not many combinations
        But sometime overload is better if there are too many optional parameters. It will be difficult to keep track
        Overload works better when creating API method
        ********************************/
    }
}
