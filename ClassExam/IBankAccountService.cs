using System;

namespace ClassExam
{
    public interface IBankAccountService
    {
        void MakeDeposit(decimal amount, DateTime date, string note);
        void MakeWithDrawal(decimal amount, DateTime date, string note);
        protected Transaction? CheckWithDrawalLimit(bool isOverDraw);
       
        void PerformMonthEndTransactions();
    }
}