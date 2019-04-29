using System;

namespace SnakesAndLaddersKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var dice = new Dice();

            Console.WriteLine("Welcome to Snakes & Ladders");
            Console.WriteLine("Starting Game and Rolling Dice");
            var count = 0;
            while (!game.IsWon())
            {
                count++;
                var spacesToMove = dice.Roll();
                game.MoveToken(spacesToMove);
                Console.WriteLine(game.IsWon()
                    ? $"Congratulations you have won, with {count} moves"
                    : $"Reached Space {game.GetLocation()}, Let's keep on trying");
            }

        }
    }
}
