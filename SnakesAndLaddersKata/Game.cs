namespace SnakesAndLaddersKata
{
    public class Game
    {
        public int Token { get; set; }

        public Game()
        {
            Token = 1;
        }
        public void MoveToken(int i)
        {
            if (Token + i > 100) return;
            Token += i;
        }

        public int GetLocation()
        {
            return Token;
        }

        public bool IsWon()
        {
            return Token == 100;
        }
    }
}