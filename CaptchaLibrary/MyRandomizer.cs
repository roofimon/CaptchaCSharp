using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary
{
    public interface IRandomizer
    {
        int Operand();
        int Operator();
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
    }
}
