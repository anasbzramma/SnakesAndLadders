using System;

namespace SnakesAndLaddersKata
{
    public class Dice : IDice
    {
        public int Roll()
        {
            return new Random().Next(1, 7);
        }
    }
}