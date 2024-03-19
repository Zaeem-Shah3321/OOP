using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Saving : Account
    {
        private double monthlyInterest;

        public Saving(string name, double balance, int accountNumber, double monthlyInterest) : base(name, balance, accountNumber)
        {
            this.monthlyInterest = balance + balance * 0.5 / 100;
        }

        public void AddInterest(double balance)
        {
            balance += monthlyInterest;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Monthly Interest: " + monthlyInterest);
        }
    }
}
