using System;
using System.Collections.Generic;

namespace ClassExam
{
    public class BankAccountManager: IBankAccountService
    {
        protected List<Transaction> allTransaction = new List<Transaction>();

       
       

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransaction.Add(deposit);
        }

        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
        }

        public void PerformMonthEndTransactions()
        {
            throw new NotImplementedException();
        }

        Transaction IBankAccountService.CheckWithDrawalLimit(bool isOverDraw)
        {
            if (isOverDraw)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
                return default;
        }
    }
}