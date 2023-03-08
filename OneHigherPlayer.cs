using System;

namespace ShootingDice
{
    // Override the Play method to make a Player who always rolls one higher than the other player

    /*
        NOTE this does not mean the OneHigherPlayer will ALWAYS win
            because it does not override ALL the Play methods
        
        the OneHigherPlayer will only "automatically" win if they are 'player 1'
            meaning, if the 'Player other' argument is NOT the OneHigher player
    */
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            Console.WriteLine($"{Name} Wins!");
        }
    }
}
