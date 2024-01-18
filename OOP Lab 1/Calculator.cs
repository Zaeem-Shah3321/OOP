using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Enter 1st Number: ");
            num1 = int.Parse(Console.ReadLine());
            int num2;
            Console.Write("Enter 2nd Number: ");
            num2 = int.Parse(Console.ReadLine());
            string sign;
            Console.Write("Enter The Sign (+,-,*,/): ");
            sign = Console.ReadLine();
            int answer = 0;
            if (sign == "+")
            {
                answer = num1 + num2;
            }
            else if (sign == "-")
            {
                answer = num1 - num2;
            }
            else if (sign == "*")
            {
                answer = num1 * num2;
            }
            else if (sign == "/")
            {
                answer = num1 / num2;
            }
            Console.WriteLine($"Answer: {answer}");
            Console.Read();
        }
    }
}
