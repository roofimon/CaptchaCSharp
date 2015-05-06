using System.Collections.Generic;

namespace CaptchaLibrary
{
    public class StringOperand:Operand
    {
        private Dictionary<int, string> mapping = new Dictionary<int, string> 
        {
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"},
        };

        public StringOperand(int value)
        {
            if (ValueIsLessThanZeroOrGreaterThanNine(value)) throw new InvalidRangeException(); 
            this.Value = value;
        }

        override public string String()
        {
            return mapping[this.Value]; 
        }
    }
}
