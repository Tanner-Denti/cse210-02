using System;

namespace game
{
    public class Deck
    {
        public int value = 0;

        public Deck()
        {

        }

        public int Draw()
        {
            Random random = new Random();
            value = random.Next(1,14);
            return value;
        }
    }
}