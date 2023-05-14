using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Lab
{
    public class Checking: Account
    {
        
        
        private const int withdrawalLimitPerDay = 300;
        private double withdrawalTotal = 0;
       
        public Checking(string OwnerName, double Balance)
               : base (OwnerName, Balance)
        {
            withdrawalTotal = 0; 
        }
        public override void Withdraw(double amount, bool IsTransfer)
        {
            if(withdrawalTotal + amount > withdrawalLimitPerDay && !IsTransfer)
            {
                Console.WriteLine("Exceed the daily max withdraw amount $300");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine($"Insufficient funds. Withdrawal denied. Account current balance: {Balance:C2}");
                
            }
            else
            {
                if(!IsTransfer)
                {
                    transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Activity = "WITHDRAW" });
                }
                base.Withdraw(amount, true);
                withdrawalTotal += amount;
            }
        }       
        public override List<Transaction> GetListOfTransactions() 
        { 
            List<Transaction> checkacList = new List<Transaction>(base.GetListOfTransactions());
            checkacList.AddRange(transactions);
            checkacList.Sort((t1, t2) => t2.Date.CompareTo(t1.Date));
            return checkacList;
        }


    }
    
}
