using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Lab
{
    public class Account
    {
        public string OwnerName { get; private set; }
        public double Balance { get; private set; }

        public List<Transaction> transactions = new List<Transaction>();
       

        public Account(string OwnerName, double Balance)
        {
            this.OwnerName = OwnerName;
            this.Balance = Balance;
        }


        public virtual double GetBalance()
        {
            return this.Balance;
        }
        public virtual void Withdraw(double amount, bool IsTransfer) 
        {
            
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal denied");
            }
            else 
            { 
                Balance -= amount;
                if (!IsTransfer)
                {
                    transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Activity = "WITHDRAW" });//not a transfer
                }
                

            }
        }
        public virtual void Deposit(double amount, bool IsTransfer)
        {
            if (!IsTransfer)
            {
                transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Activity = "DEPOSIT" });//not a transfer
            }
            Balance += amount;
        }
        public virtual void Transfer (double amount, Account destination)
        {
                this.Withdraw(amount, true);

                transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Activity = $"TRANSFER: Transfer out {this}" });
                destination.Deposit(amount, true);
                destination.transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Activity = $"TRANSFER: Transfer in {destination}" });
           
        }

        public virtual List<Transaction> GetListOfTransactions() { return transactions; }


        public void DisplayTransactions()
        {
            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine($"Amount: {transaction.Amount:C2}, Date: {transaction.Date}, Activity: {transaction.Activity}");
            }
            Console.WriteLine();
        }
    }


}