using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary
{
    abstract public class Operand
    {
        abstract public string String();
        protected int Value;

        protected  bool ValueIsLessThanZeroOrGreaterThanNine(int value)
        {
            return value < 1 || value > 9;
        }
    }
}
