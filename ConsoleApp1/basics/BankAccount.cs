using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.basics
{
    class BankAccount
    {
        private String accountHolderName;
        private double balance;

        public BankAccount()
        {
            accountHolderName = "Guest";
            balance = 0.0;
        }
        public BankAccount(String accountHolderName, double balance)
        {
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }

        public void printDetails()
        {
            Console.WriteLine("Account Holder Name: " + this.accountHolderName);
            Console.WriteLine("Current Balance: " + this.balance);
        }

        public void deposit(double amount)
        {
            balance += amount;
        }
        public void withdraw(double amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
            }
        }

    }
}
