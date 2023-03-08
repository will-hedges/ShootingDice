using System;

namespace ShootingDice
{
    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt
        {
            get { return $"{Name} says \"{tauntHolder}\""; }
        }
        public string tauntHolder { get; set; }

        public override int Roll()
        {
            Console.WriteLine(Taunt);
            return new Random().Next(DiceSize) + 1;
        }

        public SmackTalkingPlayer(string taunt)
        {
            tauntHolder = taunt;
        }
    }
}
