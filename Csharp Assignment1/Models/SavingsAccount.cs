using System;

namespace ConsoleApp1
{ 
    class AccountDetails
    {
        public AccountDetails()
        {

        }

        public string AccountName { get; }
        public string AccountNumber { get; set; }
        private int BVN { get; }

        public string checkBalance(int AccountNumber)
        {
            double accountBalance = 1000;
            return ("Your Account Balance is " + accountBalance);
        }
        public string transferMoney(string AccountNumber, string AccountOwner, int Amount)
        {
            string transferDetails = AccountNumber + AccountOwner + Amount;
            return transferDetails;
        }
    }
}
