using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class ATM
    {
        List<string> history;

        public ATM()
        {
            history = new List<string>();
        }
        public int balance = 1000;

        public void depositCash(int cash)
        {
            Console.WriteLine("Amount Of Rupees " + cash + " deposit");
            balance += cash;
            history.Add("Deposited " + cash);
        }


        public void WithDrawCash(int cash)
        {
            if (balance <= 0)
            {
                Console.WriteLine("Zero Balance, Not possible");
            }
            else if (balance < cash)
            {
                Console.WriteLine("Low Balance...., Transaction Error");

            }
            else
            {
                Console.WriteLine("Amount Of Rupees " + cash + " withdrawl");
                balance -= cash;
                history.Add("Withdrawl " + cash);
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your Balance Is {balance}");
        }

        public void History()
        {
            foreach (string transaction in history)
            {
                Console.WriteLine(transaction);
            }
        }

    }
}