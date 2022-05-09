using System;


namespace game
{
    class Round
    {
        public Round()
        {
        }
        public void startGame()
        {
            Deck deck = new Deck();
            int firstCard = 0;
            int secondCard = 0;
            string hilo = "";
            string play = "y";
            int score = 300;
            
            while (play == "y" && score > 0)
            {
                firstCard = deck.Card();
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