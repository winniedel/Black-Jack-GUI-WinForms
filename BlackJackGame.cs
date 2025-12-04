using BlackJack_GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace BlackJack_GUI
{
    public class BlackJackGame
    {
        private Form1 form; // Reference to the WinForms form

        public int userWins = 0;
        public int houseWins = 0;

        private int[] shuffledDeck;
        private List<int> userCards;
        private List<int> houseCards;

        public BlackJackGame(Form1 formReference)
        {
            // store form reference
            form = formReference; 
            StartNewGame();
        }

        // Starts a new game
        public void StartNewGame()
        {
            //Clear previous messages
            form.ClearOutput();


            shuffledDeck = MakeShuffledDeck();
            userCards = new List<int>();
            houseCards = new List<int>();

            form.Print("Let's Start Playing Black Jack");
            form.Print("New Deck: " + string.Join(" , ", shuffledDeck));

            // Deal the first card to the user
            UserHit(); // deal first card automatically
        }

        // Called when the user hits
        public void UserHit()
        {
            int card = GiveCard(ref shuffledDeck);
            userCards.Add(card);
           // form.ShowCardImage(card);

            // Dealer draws automatically if under 17
            if (houseCards.Sum() < 17)
            {
                int dealerCard = GiveCard(ref shuffledDeck);
                houseCards.Add(dealerCard);
            }
           
            form.Print("New Deck: " + string.Join(" , ", shuffledDeck));
            form.Print("Your Hand: " + string.Join(", ", userCards));
            form.Print("Dealer Hand: " + string.Join(", ", houseCards));

            // Check for bust or blackjack
            if (userCards.Sum() > 21)
            {
                form.Print("You're Busted! Dealer Wins.");
                IncrementHouseScore();
                ShowScores();
            }
            else if (userCards.Sum() == 21)
            {
                form.Print("Blackjack! You Win!");
                IncrementUserScore();
                ShowScores();
            }
            else
            {
                form.Print("Wanna Keep Playing? Press Hit, if Not Press Stand");
            }
        }

        // Called when the user stands
        public void UserStand()
        {
            // Dealer draws until 17 or higher
            while (houseCards.Sum() < 17)
            {
                int dealerCard = GiveCard(ref shuffledDeck);
                houseCards.Add(dealerCard);
                form.Print("Dealer drew: " + dealerCard);
            }

            form.Print("Final Hands:");
            form.Print("Your Hand: " + string.Join(", ", userCards));
            form.Print("Dealer Hand: " + string.Join(", ", houseCards));

            // Determine winner
            //Adds the sum of the cards in each hand to compare who has the higher value
            int userSum = userCards.Sum();
            int houseSum = houseCards.Sum();

            if (houseSum > 21 || userSum > houseSum)
            {
                form.Print("You Win!");
                IncrementUserScore();
            }
            else if (houseSum > userSum)
            {
                form.Print("Dealer Wins!");
                IncrementHouseScore();
            }
            else
            {
                form.Print("It's a Tie!");
            }

            ShowScores();
            form.Print("Wanna Play Again? Press 'New Game' to Continue");
        }

        // Method to show current scores
        private void ShowScores()
        {
            form.Print("Scores - House: " + GetHouseWins() + ", User: " + GetUserWins());
        }

        // Fisher-Yates shuffle algorithm
        // Shuffles the deck of cards
        private static void Shuffle(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Creates and returns a shuffled deck of cards
        //Makes an array of 52 cards and modulo operator to assign values from 1 to 13
        private int[] MakeShuffledDeck()
        {
            int[] array = new int[52];
            for (int i = 0; i < array.Length; i++)
                array[i] = (i % 13) + 1;
            Shuffle(array);
            return array;
        }

        // Gives a card from the deck and removes it from the deck
        //Returns the card given
        private int GiveCard(ref int[] deck)
        {
            int card = deck[deck.Length - 1];
            int[] tempDeck = new int[deck.Length - 1];
            Array.Copy(deck, tempDeck, deck.Length - 1);
            deck = tempDeck;
            return card;
        }

        // Score management methods
        //Increments and retrieves user and house scores
        public void IncrementUserScore() { userWins++; }
        public void IncrementHouseScore() { houseWins++; }
        public int GetUserWins() { return userWins; }
        public int GetHouseWins() { return houseWins; }
    }
}
