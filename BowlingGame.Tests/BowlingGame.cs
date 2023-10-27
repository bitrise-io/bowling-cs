using Xunit;

namespace BowlingGame.Tests;

public class BowlingGameTests
{
    [Theory]
    // simple game
    [InlineData(new[]{
        1, 2,   // frame 1
        4, 1,   // frame 2
        5, 3 }, // frame 3
        1+2 + 4+1 + 5+3)]

    // spare game
    [InlineData(new[]{
        1, 2,   // frame 1
        9, 1,   // frame 2 (spare)
        5, 3 }, // frame 3
        1+2 + 1+9+5 + 5+3)]

    public void Score(int[] rolls, int expectedScore)
    {
        var game = new BowlingGame();

        foreach(var roll in rolls) {
            game.Roll(roll);
        }

        Assert.Equal(expectedScore, game.Score);
    }
}
