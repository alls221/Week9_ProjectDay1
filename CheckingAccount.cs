using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_ProjectDay1
{
    class CheckingAccount: Accounts
    {
        decimal checkingBalance = 10;

        public CheckingAccount ()
        {
            Balance = checkingBalance;
            AccountNumber = GetAccountnumber();
        }
    }
}
