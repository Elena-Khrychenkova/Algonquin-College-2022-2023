using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Lab
{
    public class Saving: Account
    {
        private static double penalty = 10;
        private static double InterestRate = 0.03;
        public Saving (string OwnerName, double Balance)
            : base(OwnerName, Balance)
        {

        }

        public void ApplyPenalty(double amount)
        {
            base.Withdraw(amount, true);
            transactions.Add(new Transaction { Date = DateTime.Now, Amount = amount, Activity = "Penalty" });
        }
        public override void Deposit(double amount, bool IsTransfer)
        {

                base.Deposit(amount, IsTransfer);
                double interest = amount * InterestRate;
                base.Deposit(interest, true);
                transactions.Add(new Transaction { Date = DateTime.Now, Amount = interest, Activity = "DEPOSIT:Interest" });
        }
 

        public override List<Transaction> GetListOfTransactions()
        {
            List<Transaction> saveacList = new List<Transaction>(base.GetListOfTransactions());
            saveacList.AddRange(transactions);
            saveacList.Sort((t1, t2) => t2.Date.CompareTo(t1.Date));
            return saveacList;
        }
    }
    
}
