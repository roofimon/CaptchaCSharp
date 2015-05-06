using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaptchaLibrary
{
    public class Operator
    {
        private enum s
        {
            plus = 1,
            multiply,
            minus
        };
        private string oper;

        public Operator(int value) 
        {
            if (value == (int)s.plus)
            {
                this.oper = "+";
            }
            else if(value == (int)s.multiply)
            {
                this.oper = "*";
            }
            else if (value == (int)s.minus)
            {
                this.oper = "-"; 
            }
        }

        public string String()
        {
            return this.oper;
        }

    }
}
