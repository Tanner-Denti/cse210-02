using System;


namespace game
{
    class Deck
    {
        static Deck()
        {
        }

        public int Card()
        {
            Random rnd = new Random();

            return rnd.Next(1, 13);
        }
    }
}