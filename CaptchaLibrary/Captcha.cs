namespace CaptchaLibrary
{
    public class Captcha
    {
        private Operand _leftOperand;
        private Operand _rightOperand;
        private readonly Operator _oper;

        public Captcha(int pattern, int leftValue, int operatorValue, int rightValue)
        {
            SetLeftOperand(pattern, leftValue);
            SetRightOperand(pattern, rightValue);
            this._oper = new Operator(operatorValue);
        }

        private void SetRightOperand(int pattern, int rightValue)
        {
            if (IsStringIntegerPattern(pattern))
            {
                this._rightOperand = new IntegerOperand(rightValue);
            }
            else
            {
                this._rightOperand = new StringOperand(rightValue);
            }
        }

        private void SetLeftOperand(int pattern, int leftValue)
        {
            if (IsStringIntegerPattern(pattern))
            {
                this._leftOperand = new StringOperand(leftValue);
            }
            else
            {
                this._leftOperand = new IntegerOperand(leftValue);
            }
        }

        private bool IsStringIntegerPattern(int pattern)
        {
            return pattern == 1;
        }

        public Operand LeftOperand()
        {
            return this._leftOperand;
        }

        public Operand RightOperand()
        {
            return this._rightOperand;
        }

        public Operator Operator()
        {
            return this._oper;
        }
    }
}
