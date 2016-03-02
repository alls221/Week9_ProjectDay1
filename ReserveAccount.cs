using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_ProjectDay1
{
    class ReserveAccount:Accounts
    {
        decimal reserveBalance = 100;

        public ReserveAccount ()
        {
            Balance = reserveBalance;
            AccountNumber = GetAccountnumber();
        }
    }
}
