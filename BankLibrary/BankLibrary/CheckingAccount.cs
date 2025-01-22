using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CheckingAccount : Account
    {
        public decimal overdraftLimit {  get; set; }
        public CheckingAccount(String accountNumber, string accountName, decimal initialBalance, decimal overDraftLimit) : base(accountNumber, accountName, initialBalance)
        {
            overDraftLimit = overDraftLimit
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawl amount must be positive");
            if (amount > Balance + overdraftLimit) throw new InvalidOperationException("Overdraft limit exceeded");
            this.Withdraw(amount);
        }
    }
}
