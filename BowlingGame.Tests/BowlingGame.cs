using Xunit;

namespace BowlingGame.Tests;

public class BowlingGameTests
{
    [Theory]
    [InlineData(new[]{ 0, 0, 0, 0, 0, 0 }, 0)]
    public void Score(int[] rolls, int expectedScore) 
    {
        var game = new BowlingGame();

        foreach(var roll in rolls) {
            game.Roll(roll);
        }

        Assert.Equal(expectedScore, game.Score);
    }
}