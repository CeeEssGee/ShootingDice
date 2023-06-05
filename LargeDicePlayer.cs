namespace ShootingDice
{
    // A Player who brings a large die to the game
    // CG: inherits properties from Player
    public class LargeDicePlayer : Player
    {
        // CG: Can we override without any additional naming conventions?
        public LargeDicePlayer()
        {
            DiceSize = 20;
        }
    }
}