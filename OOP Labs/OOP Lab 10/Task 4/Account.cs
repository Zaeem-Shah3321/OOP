using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Account
    {
        private string name;
        private double balance;
        private int accountNumber;

        public Account(string name, double balance, int accountNumber)
        {
            this.name = name;
            this.balance = balance;
            this.accountNumber = accountNumber;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Account Number: " + accountNumber);
        }
    }
}
