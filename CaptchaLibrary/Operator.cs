using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaptchaLibrary
{
    public class Operator
    {
        private string oper;

        public Operator(int oper)
        {
            if (oper == 1)
            {
                this.oper = "+";
            }
            else if(oper == 2)
            {
                this.oper = "*";
            }
            else if (oper == 3)
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
