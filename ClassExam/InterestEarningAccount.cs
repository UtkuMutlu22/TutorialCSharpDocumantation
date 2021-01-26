﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExam
{
   public class InterestEarningAccount:BankAccount
    {
        public InterestEarningAccount(string name,decimal initialBalance):base(name,initialBalance)
        {

        }
        public new void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}
