using SnakesAndLaddersKata;
using Xunit;

namespace SnakesAndLaddersKataTests
{
    public class GameTests
    {
        private readonly Game _game;

        public GameTests()
        {
            _game = new Game();
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(3, 4)]
        public void TokenCanMoveAcrossBoardBySpaces(int start, int end)
        {
            _game.MoveToken(start);

            var location = _game.GetLocation();

            Assert.Equal(end, location);
        }

        [Fact]
        public void TokenMustMoveFromLastSpace()
        {
            _game.MoveToken(3);
            _game.MoveToken(4);

            var location = _game.GetLocation();

            Assert.Equal(8, location);
        }

        [Theory]
        [InlineData(3, true)]
        [InlineData(4, false)]
        public void PlayerWillWinWhenTokenReachLimit(int moves, bool didWin)
        {
            _game.MoveToken(96);
            _game.MoveToken(moves);

            var hasWon = _game.IsWon();

            Assert.Equal(hasWon, didWin);
        }

        [Fact]
        public void GameMustNeverPassSpaceLimit()
        {
            _game.MoveToken(10);

            var location = _game.GetLocation();

            _game.MoveToken(150);

            Assert.Equal(11, location);
        }
    }
}
