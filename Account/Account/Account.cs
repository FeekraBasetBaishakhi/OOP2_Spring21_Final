﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }
        public Transaction[] transactions { get; set; }
        public int totalNumberOfTransation { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }
       
        public void Deposit(double amount)
        {
            Balance += amount;
            transactions[totalNumberOfTransation++] = new Transaction(this, this, amount, "Self deposit");
        }
        virtual public void Withdraw(double amount)
        {
        }

        virtual public void Transfer(Account a, double amount)
        {

        }
        void showAllTransaction()
        { 
        }

    }
}