using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExam
{
    class GiftCardAccount:BankAccount
    {
        private decimal _monthlyDeposit = 0;
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;
        public new void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
