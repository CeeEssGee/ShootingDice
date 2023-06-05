using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    // inherits properties from Player
    public class SmackTalkingPlayer : Player
    {
        public string Taunt = "Your mother was a hamster and your father smelt of elderberry!";

        // override Roll()
        public override int Roll()
        {
            System.Console.WriteLine($"{this.Name} says: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }
}