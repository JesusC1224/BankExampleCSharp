using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;

namespace BankServices
{
    public class InterestService
    {
        public void ApplyInterestToAccounts(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                if (account is SavingsAccount savingsAccount)
                {
                    savingsAccount.ApplyInterest();
                    Console.WriteLine($"Interest applies to SavingsAccount ({savingsAccount.AccountNumber}) New Balance {savingsAccount.Balance:C}");
                }

                if (account is HighInterestSavingsAccount highInterestSavingsAccount)
                {
                    highInterestSavingsAccount.ApplyInterest();
                    highInterestSavingsAccount.ApplybonucInterest(0.01m);
                    Console.WriteLine($"Interest applies to SavingsAccount ({highInterestSavingsAccount.AccountNumber}) New Balance {highInterestSavingsAccount.Balance:C}");
                }
            }
        }
    }
}
