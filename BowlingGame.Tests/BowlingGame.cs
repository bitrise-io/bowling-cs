using Xunit;

namespace BowlingGame.Tests;

public class BowlingGameTests
{
    [Theory]
    // gutter game
    [InlineData(new[]{ 
        0, 0,   // frame 1
        0, 0,   // frame 2
        0, 0 }, // frame 3
        0)]
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
    // strike game
    [InlineData(new[]{ 
        1, 2,   // frame 1 
        10,     // frame 2 (strike)
        5, 3 }, // frame 3
        1+2 + 10+5+3 + 5+3)]
        
    public void Score(int[] rolls, int expectedScore) 
    {
        var game = new BowlingGame();

        foreach(var roll in rolls) {
            game.Roll(roll);
        }

        Assert.Equal(expectedScore, game.Score);
    }
}
