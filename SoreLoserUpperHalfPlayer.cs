using System;
using System.Linq;

namespace ShootingDice
{
    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            return new Random().Next(DiceSize / 2, DiceSize);
        }

        public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                throw new Exception(
                    $"{Name} says \"You're playing with loaded dice! I'm outta here!\""
                );
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
