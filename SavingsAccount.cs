using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_ProjectDay1
{
    class SavingsAccount:Accounts
    {
        decimal savingsBalance = 10000;
        public SavingsAccount ()
        {
            Balance = savingsBalance;
            AccountNumber = GetAccountnumber();
        }
    }
}
