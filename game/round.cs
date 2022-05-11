using System;


namespace game
{
    class Round
    {
        Deck deck;
        int firstCard;
        int secondCard;
        string hilo;
        string play;
        int score;
        
        public Round()
        {
            deck = new Deck();
            firstCard = 0;
            secondCard = 0;
            hilo = "";
            play = "y";
            score = 300;
        }
        public void startGame()
        {
            firstCard = deck.Card();
            while (play == "y" && score > 0)
            {
                
                secondCard = deck.Card();

                Console.Write($"\nThe card is: {firstCard}");
                hilo = input();
                Console.Write($"Next card was: {secondCard}");
                score = updateScore(firstCard, secondCard, score, hilo);
                
                if (score < 0)
                {   
                    Console.WriteLine("\n\nYour score is: 0\nBetter luck next time!");
                    break;
                }
                else
                {
                Console.WriteLine($"\nYour score is: {score}");
                play = playAgain();

                firstCard = secondCard;
                }
            }
        }
        public string input()
        {
            Console.Write("\nHigher or lower? [h/1] ");
            string userAns = Console.ReadLine();
            return userAns;
        }
        public int updateScore(int firstCard, int secondCard, int score, string hilo)
        {
            
             if (hilo == "h" && secondCard > firstCard)
            {
                score = score + 100;
            }
            else if (hilo == "l" && secondCard < firstCard)
            {
                score = score + 100;
            }
            else if (hilo == "h" && secondCard <= firstCard)
            {
                score = score - 75;
            }
            else if (hilo == "l" && secondCard >= firstCard)
            {
                score = score - 75;
            }
            
            return score;
        }
        public string playAgain()
        {
            Console.Write("Play again? [y/n] ");
            string userAns = Console.ReadLine();
            
            return userAns;
        }
    }
}