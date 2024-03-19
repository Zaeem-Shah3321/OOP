using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Saving s = new Saving("John", 1000, 12345, 0.5);
            s.Deposit(500);
            s.Withdraw(200);
            s.Print();

            Current c = new Current("John", 1000, 12345, 3);
            c.Deposit(500);
            c.Withdraw(200);
            c.Print();

            Console.ReadKey();
        }
    }
}
