namespace CaptchaLibrary
{
    public class IntegerOperand:Operand
    {
        public IntegerOperand(int value)
        {
            if (valueIsLessThanZeroOrGreaterThanNine(value)) throw new InvalidRangeException();
            this.value = value;
        }
        
        override public string String()
        {
            return this.value.ToString();
        }
    }
}
