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
        public calculator()
        {
            number1 = 10;
            number2 = 10;
        }
        public int add()
        {
            return number1 + number2;
        }
        public int subtract()
        {
            return number1 - number2;
        }
        public int multiply()
        {
            return number1 * number2;
        }
        public int divide()
        {
            return number1 / number2;
        }
        public int mod()
        {
            return number1 % number2;
        }

    }
}
