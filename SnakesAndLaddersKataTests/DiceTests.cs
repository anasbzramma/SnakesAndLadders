using SnakesAndLaddersKata;
using Xunit;

namespace SnakesAndLaddersKataTests
{
    public class DiceTests
    {
        [Fact]
        public void DiceShouldReturnValuesBetween1And6()
        {
            var dice = new Dice();

            int result = dice.Roll();

            Assert.InRange(result, 1, 6);
        }
    }
}