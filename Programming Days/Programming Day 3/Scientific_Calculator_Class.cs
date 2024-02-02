using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class calculator
    {
        public double number1;
        public calculator()
        {
            number1 = 10;
        }
        public double sq_rt()
        {
            return Math.Sqrt(number1) ;
        }
        public double exponential()
        {
            return Math.Exp(number1);
        }
        public double log()
        {
            return Math.Log(number1);
        }
        public double trig(string types)
        {
            if (types == "sin")
            {
                return Math.Sin(number1);
            }
            else if (types == "cos")
            {
                return Math.Cos(number1);
            }
            else if (types == "tan")
            {
                return Math.Tan(number1);
            }
            else
            {
                return 0;
            }
        }
        
    }
}
