using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Enter First Number: ");
            num1 = int.Parse(Console.ReadLine());
            int num2;
            Console.Write("Enter Socond Number: ");
            num2 = int.Parse(Console.ReadLine());
            string opr;
            Console.Write("Enter The Operator (+, -, *, /): ");
            opr = Console.ReadLine();
            calculator s1 = new calculator(num1,num2,opr);
            Console.WriteLine($"Answer is: {s1.ans}");
            Console.ReadKey();
        }
    }
}
