using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }
        List<string> taunts = new List<string>
        {
            "Oh, you're approaching me? You're approaching ME?!",
            "Now TASTE deez dice!",
            "I'm gonna ROLL you, ya frickin' jabroni!",
            "Can you EVEN count to 6, NERD?",
            "I'm about to YAHTZEE all over your face!",
            "You roll like you fart.",
            "I came here to roll dice and eat popcorn... and I'm all out of popcorn.",
            "I'm gonna wreck you like Godzilla wrecks Tokyo!"
        };

        public CreativeSmackTalkingPlayer()
        {
            Taunt = taunts[new Random().Next(0, taunts.Count)];
        }

        public override int Roll()
        {
            Console.WriteLine($"{Name} says \"{Taunt}\"");
            return new Random().Next(DiceSize) + 1;
        }
    }
}
