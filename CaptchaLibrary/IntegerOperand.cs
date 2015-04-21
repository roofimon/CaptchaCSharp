namespace CaptchaLibrary
{
    public class IntegerOperand:Operand
    {
        public IntegerOperand(int value)
        {
            if (ValueIsLessThanZeroOrGreaterThanNine(value)) throw new InvalidRangeException();
            this.value = value;
        }
        
        override public string String()
        {
            return this.value.ToString();
        }
    }
}
