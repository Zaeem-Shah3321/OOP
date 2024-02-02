using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class calculator
    {
        public int number1;
        public int number2;
        public calculator()
        {
            number1 = 10;
            number2 = 10;
        }
        public calculator(int n1, int n2)
        {
            number1 = 10;
            number2 = 10;
        }
        public int add(int n1 , int n2)
        {
            return n1 + n2;
        }
        public int subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        public int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public int divide(int n1, int n2)
        {
            return n1 / n2;
        }
        public int mod(int n1, int n2)
        {
            return n1 % n2;
        }

    }
}
