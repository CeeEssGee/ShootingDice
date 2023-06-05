using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {


        public override int Roll()
        {


            List<string> taunts = new List<string>
        {
            "You look like what morning breath smells like.",
            "If you tried to give me cpr I would probably throw myself back under water",
            "I am not a fan of you",
            "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
            "I'd rather walk than be on the same plane as you",
            "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
            "Do you have to be so...like that?"
        };

            // random class assigned to "random" so we can use it later
            Random random = new Random();

            int randomNumber = new Random().Next(0, 7);
            string Taunt = taunts[randomNumber];

            System.Console.WriteLine($"{this.Name} says: {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }





    }
}