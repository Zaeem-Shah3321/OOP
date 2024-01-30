using Bank;
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
            ATM a1 = new ATM();
            a1.CheckBalance();
            a1.depositCash(500);
            a1.depositCash(750);
            a1.WithDrawCash(300);
            a1.WithDrawCash(100);
            a1.CheckBalance();
            a1.WithDrawCash(2000);
            a1.CheckBalance();
            a1.History();
            Console.ReadKey();
        }
    }
}
