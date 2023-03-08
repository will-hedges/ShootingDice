using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            while (true)
            {
                Console.Write($"Enter your roll: ");
                string answer = Console.ReadLine();

                bool isNumber = false;
                int numAnswer;
                isNumber = int.TryParse(answer, out numAnswer);

                if (isNumber && numAnswer >= 1 && numAnswer <= 6)
                {
                    return numAnswer;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 6.");
                    continue;
                }
            }
        }
    }
}
