using System;

namespace ShootingDice
{
    // A Player that throws an exception when they lose to the other player
    public class SoreLoserPlayer : Player
    {
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
                throw new SoreLoserException($"{Name} says \"I'm taking my dice and going home!\"");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}
