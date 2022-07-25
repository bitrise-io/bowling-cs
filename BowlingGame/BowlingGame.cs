namespace BowlingGame;

public class BowlingGame
{
    private List<int> rolls = new List<int>();

    public int Score { 
        get 
        {
            int sum = 0;
            for (int i=0; i<rolls.Count; i++) {
                sum += rolls[i];

                if ((i >= 2) && (i%2 == 0) && 
                    (rolls[i - 2] + rolls[i - 1] == 10))
                    sum += rolls[i];
            }

            return sum;
        } 
     }

    public void Roll(int pinCount)
    {
        rolls.Add(pinCount);        
    }
}
