using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class calculator
    {
        public int ans = 0;
        public calculator(int n1 , int n2 , string opr)
        { 
            if (opr == "+")
            {
                ans = n1 + n2;
            }
            else if(opr == "-")
            {
                ans = n1 - n2; 
            }
            else if (opr == "*") 
            {
                ans = n1 * n2;
            }
            else if (opr == "/")
            {
                ans = n1 / n2;
            }
        }
    }
}
