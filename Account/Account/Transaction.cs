using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Transection
    {
        Account sender;

        Account receiver;
        public string AdditionalInfo { get; set; }

        public int Amount { get; set; }


        public Transection() { }
        public Transection(Account sender, Account receiver, int amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            Amount = amount;
            AdditionalInfo = additionalInfo;
        }
        public void ShowInfo()
        {
            {
                Console.WriteLine("Transaction: {0}", AdditionalInfo);
                Console.WriteLine("Amount: {0}", Amount);
                Console.WriteLine("Sender Account: {0}", sender.AccName);
                Console.WriteLine("Sender Id: {0} ", sender.AccNo);
                Console.WriteLine("Receiver Account: {0}", receiver.AccName);
                Console.WriteLine("Receiver Id: {0} ", receiver.AccNo);
              

            }

        }
    }
}
