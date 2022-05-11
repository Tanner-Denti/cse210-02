namespace game
{
    public class Round
    {
        Deck deck;
        bool gameStatus;
        int score;
        int totalScore;
        int card;
        int nextCard;
        string highLow;
        string continuePlaying;


        public Round()
        {
            this.deck = new Deck();
            gameStatus = true;
            score = 0;
            totalScore = 300;
            card = 0;
            nextCard = 0;
            highLow = " ";
            continuePlaying = " ";
        }


        public void StartGame()
        {
            while (gameStatus)
            {
                GetInputs();
                DrawNextCard();
                GetScore();
                UpdateNextCard();
                DetermineGameStatus();
            }
        }

        public void GetInputs()
        {
            if (card == 0)
            {
                card = deck.Draw();
            }
            Console.WriteLine($"The card is: {card}");
            Console.Write("Higher or lower? [h/l] ");
            highLow = Console.ReadLine();
        }

        public void DrawNextCard()
        {
            nextCard = deck.Draw();
            Console.WriteLine($"Next card was: {nextCard}");
        }

        public void GetScore()
        {
            if (totalScore < 0)
            {
                totalScore = 0;
            }
            else if (highLow == "h")
            {
                if (nextCard > card)
                {
                    totalScore = 100 + totalScore;
                }
                else if (nextCard < card)
                {
                    totalScore = totalScore - 75;
                }             
            }
            else if (highLow =="l")
            {
                if (nextCard < card)
                {
                    totalScore = 100 + totalScore;
                }
                else if (nextCard > card)
                {
                    totalScore = totalScore - 75;
                }   
            }
            Console.WriteLine($"Your score is: {totalScore}");

        }

        public void UpdateNextCard()
        {
            card = nextCard;
        }

        public void DetermineGameStatus()
        {

            if (totalScore != 0)
            {
                Console.Write("Play again? [y/n] ");
                continuePlaying = Console.ReadLine();
                if (continuePlaying == "y")
                {
                    gameStatus = true;
                }
                else if (continuePlaying == "n")
                {
                    gameStatus = false;
                }
            }

            else
            {
                gameStatus = false;
            }

            Console.WriteLine(" ");

        }
    }
}