using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment1.Models
{
    class SavingsAccount
    {
            public string AccountName { get; }
            public string AccountNumber { get; }
            private int BVN { get; }

            string checkBalance(int AccountNumber, int AccountBalance)
            {
                return ("Your Account Balance ");
            }
            string transferMoney(string AccountNumber, string AccountOwner, int Amount)
            {
                string transferDetails = AccountNumber + AccountOwner + Amount;
                return transferDetails;
            }

            void recieveMoney()
            {

            }
    }
}
