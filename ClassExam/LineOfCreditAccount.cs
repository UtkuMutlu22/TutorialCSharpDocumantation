﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExam
{
    class LineOfCreditAccount : BankAccount
    {
        // <ConstructLineOfCredit>
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {
        }
        // </ConstructLineOfCredit>

        // <ApplyMonthendInterest>

        public new void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                var interest = -Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
        // </ApplyMonthendInterest>

        // <AddOverdraftFee>
        protected  Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;
        // </AddOverdraftFee>
    }
}