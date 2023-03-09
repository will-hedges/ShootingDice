using System;

namespace ShootingDice
{
    public class SoreLoserException : Exception
    {
        public SoreLoserException(string message)
            : base(message) { }
    }
}
