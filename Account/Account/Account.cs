using System;
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
        public int totalNumberOfTransections { get; set; }

        Transection[] transections;
        public Account() { }

        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            transections = new Transection[80];
        }
        public void addTransaction(params Transection[] transections)

        {
            foreach (Transection transaction in transections)
            {
                this.transections[totalNumberOfTransections++] = transaction;

            }
        }

        public void showAllTransection()
        {
            for (int k = 0; k < totalNumberOfTransections; k++)
            {
                transections[k].ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }


        public void Deposit(int amount)
        {
            Balance += amount;
            transections[totalNumberOfTransections++] = new Transection(this, this, amount, "self deposited");
        }
        virtual public void Withdraw(int amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Balance After Withdraw is: {0}}", Balance);
                transections[totalNumberOfTransections++] = new Transection(this, this, amount, "self Widhdrawn");
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance");
            }
        }


        virtual public void Transfer(Account transaction, int amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                Console.WriteLine("Balance After Transfer is: {0}}", Balance);
                transections[totalNumberOfTransections++] = new Transection(this, transaction, amount, "self Transfered");
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance");
            }
        }


    }
}