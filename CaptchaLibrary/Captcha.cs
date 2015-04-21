using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary
{
    public class Captcha
    {
        private Operand leftOperand;
        private Operand rightOperand;
        private Operator oper;

        public Captcha(int pattern, int leftValue, int operatorValue, int rightValue)
        {
            SetLeftOperand(pattern, leftValue);
            SetRightOperand(pattern, rightValue);
            this.oper = new Operator(operatorValue);
        }

        private void SetRightOperand(int pattern, int rightValue)
        {
            if (IsStringIntegerPattern(pattern))
            {
                this.rightOperand = new IntegerOperand(rightValue);
            }
            else
            {
                this.rightOperand = new StringOperand(rightValue);
            }
        }

        private void SetLeftOperand(int pattern, int leftValue)
        {
            if (IsStringIntegerPattern(pattern))
            {
                this.leftOperand = new StringOperand(leftValue);
            }
            else
            {
                this.leftOperand = new IntegerOperand(leftValue);
            }
        }

        private bool IsStringIntegerPattern(int pattern)
        {
            return pattern == 1;
        }

        public Operand LeftOperand()
        {
            return this.leftOperand;
        }

        public Operand RightOperand()
        {
            return this.rightOperand;
        }

        public Operator Operator()
        {
            return this.oper;
        }
    }
}
