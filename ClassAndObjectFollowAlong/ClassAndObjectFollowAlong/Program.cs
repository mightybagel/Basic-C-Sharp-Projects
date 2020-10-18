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
        //Inheritance is one of the 4 pillars of oop
        //best coding practice of inheritance is the acronym DRY: Don't Repeat Yourself
        static void Main(string[] args)
        {
            /********************
             Note3: Out parameter : out parameter doesn’t require the variables 
            to be initialized before it passed to the method. 
            But before it returns a value to the calling method, 
            the variable must be initialized in the called method.
            see: public static Deck Shuffle(Deck deck, int times = 1)

             ******************/

            //Card card = new Card() { Face = "King", Suits = "Spades" };//different way to initialize instance of class card

            //This shows inheritance from Game class
            //TweentyOneGame game = new TweentyOneGame();



            //Game game = new Game();
            //Game game = new TweentyOneGame();//Polymorphism: use when has many type of game



            TweentyOneGame game = new TweentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            

            //game.Play();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck = Shuffle(deck);//comment this to get the ordered deck


            /********************
             Note 2
             Name parameter: does not change anything 
             Easier to read
             deck: deck, time: 3 --> name parameter
            //deck = Shuffle(deck:deck, times: 3); 
             *******************/

            //deck.Shuffle(3);

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
            //foreach (Card card in deck.Cards)
           //{
             //   Console.WriteLine(card.Face + " of " + card.Suits);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Easy way to format string: can add {1} after {0} and add another variable need to be formatted after timeshuffled
            
            
           //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suits);
            //Console.ReadLine();
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
