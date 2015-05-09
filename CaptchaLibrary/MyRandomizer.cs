using System;

namespace CaptchaLibrary
{
    public interface IRandomizer
    {
        int Operand();
        int Operator();

        int Pattern();
    }

    public class MyRandomizer : IRandomizer
    {
        private readonly Random _randomizer;
        private const int LowerBound = 1;

        public MyRandomizer()
        {
            this._randomizer = new Random();            
        }

        public int Operand()
        {
            const int upperBound = 10;
            return this._randomizer.Next(LowerBound, upperBound);
        }

        public int Operator()
        {
            const int upperBound = 3;
            return this._randomizer.Next(LowerBound, upperBound);
        }

        public int Pattern()
        {
            const int upperBound = 2;
            return this._randomizer.Next(LowerBound, upperBound);
        }
    }
}
