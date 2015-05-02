using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Account
    {
        public string AccountNumber;
        public string AccountName;
        public double AccountBalance;

        public string Deposit(double amount)
        {
            if (AccountName!=null && AccountNumber!=null)
            {
                AccountBalance += amount;
                return "Deposit Successfully Done";    
            }
            else
            {
                return "Please Create Account ";
            }
            
        }

        public string Withdraw(double amount)
        {
            if (AccountName != null && AccountNumber != null)
            {
                if (AccountBalance >= amount)
                {
                    AccountBalance -= amount;
                    return "Withdraw Successfully Done";
                }
                else
                {
                    return "You Have not Enough Balance";
                } 
            }
            else
            {
                return "Please Create Account ";
            }
        }
    }
}
